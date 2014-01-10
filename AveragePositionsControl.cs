using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using OEC.Data;

namespace OEC.API.Example
{
    /// <summary>
    ///     Average positions control. Visualize current average positions of account, provides exit position functionality
    /// </summary>
    public partial class AveragePositionsControl : BaseControl
    {
        /// <summary>
        ///     Position list binding source. Used to store current selected position
        /// </summary>
        private readonly BindingSource _positionsBindingSource = new BindingSource();

        /// <summary>
        ///     Average positions control constructor
        /// </summary>
        public AveragePositionsControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Prepares average positions related event handlers
        /// </summary>
        protected override void PrepareControlEventHandlers()
        {
            base.PrepareControlEventHandlers();

            OECClient.Global.OnAvgPositionChanged += Global_OnAvgPositionChanged;
            OECClient.Global.OnLoginComplete += Global_OnLoginComplete;
            Globals.OnCurrentAccountChanged += Globals_OnCurrentAccountChanged;
            UpdatePositions(null);
        }

        /// <summary>
        ///     Occurs when current account changed
        /// </summary>
        void Globals_OnCurrentAccountChanged(AccountOrAB accountOrAB)
        {
            UpdatePositions(null);
        }

        /// <summary>
        ///     Update positions when login complete
        /// </summary>
        private void Global_OnLoginComplete()
        {
           // Account account = OECClient.Global.Accounts.First;
            UpdatePositions(null);
        }

        /// <summary>
        ///     Update position when account's average position changed
        /// </summary>
        private void Global_OnAvgPositionChanged(Account account, Position contractPosition)
        {
            UpdatePositions(account);
        }

        /// <summary>
        ///     Updates Average position control
        /// </summary>
        public void UpdatePositions(Account account)
        {
            if (OECClient.Global.ConnectionClosed)
                return;

            if (account == null || Globals.CurrentAccountOrAB.HasAccount(account))
            {

                _positionsBindingSource.DataSource = AvgPositionListEntry.ConvertFromOecAvgPositionList();

                dgAvgPositions.DataSource = _positionsBindingSource;
            }
        }


        /// <summary>
        ///     Attempts to close position
        /// </summary>
        private void btExit_Click(object sender, EventArgs e)
        {
            if (_positionsBindingSource.Current == null)
                return;

            var pos = (AvgPositionListEntry) _positionsBindingSource.Current;

            NewOrderDraft draft = OECClient.Global.CreateDraft();

            draft.Account = pos.Position.Account;
            draft.Side = (pos.Position.Net.Volume < 0) ? OrderSide.Buy : OrderSide.Sell;
            draft.Contract = pos.Position.PositionContract;
            draft.Quantity = Math.Abs(pos.Position.Net.Volume);
            draft.Type = OrderType.Market;

            if (draft.Quantity == 0)
                return; // nothing to close

            if (
                MessageBox.Show("Send " + draft + " ?", "Confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) ==
                DialogResult.No)
                return;
            OECClient.Global.SendOrder(draft);
        }

        /// <summary>
        ///     Highlight position which can be closed
        /// </summary>
        private void dgAvgPositions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var element = (AvgPositionListEntry) _positionsBindingSource[e.RowIndex];
            e.CellStyle.ForeColor = element.NetPos == 0 ? Color.Gray : Color.Black;
        }
    }

    /// <summary>
    ///     Used for simple representation(visualization) of average positions
    /// </summary>
    internal class AvgPositionListEntry
    {
        /// <summary>
        ///     Native position
        /// </summary>
        private readonly IPosition _position;

        /// <summary>
        ///     Creates instance
        /// </summary>
        /// <param name="position">Native OEC API position on which to create instance</param>
        private AvgPositionListEntry(IPosition position)
        {
            _position = position;
        }

        /// <summary>
        ///     Position contract
        /// </summary>
        public string Contract
        {
            get { return _position.Contract.ToString(); }
        }

        /// <summary>
        ///     Position bought number
        /// </summary>
        public int BoughtNum
        {
            get { return _position.Long.Volume; }
        }

        /// <summary>
        ///     Position bought average price
        /// </summary>
        public string BoughtAvgPrice
        {
            get { return _position.Contract.PriceToString(_position.Long.Price); }
        }

        /// <summary>
        ///     Position sold number
        /// </summary>
        public int SoldNum
        {
            get { return _position.Short.Volume; }
        }

        /// <summary>
        ///     Position sold average price
        /// </summary>
        public string SoldAvgPrice
        {
            get { return _position.Contract.PriceToString(_position.Short.Price); }
        }

        /// <summary>
        ///     Net position
        /// </summary>
        public int NetPos
        {
            get { return _position.Net.Volume; }
        }

        /// <summary>
        ///     Total profit/loss
        /// </summary>
        public string TotalPnL
        {
            get { return _position.Contract.PriceToString(_position.Gain); }
        }

        /// <summary>
        ///     Open profit/loss
        /// </summary>
        public string OpenPnL
        {
            get { return _position.Contract.PriceToString(_position.OTE); }
        }

        /// <summary>
        ///     Realized profit/loss
        /// </summary>
        public string RealizedPnL
        {
            get { return _position.Contract.PriceToString(_position.NetGain); }
        }

        /// <summary>
        ///     Native position instance
        /// </summary>
        public IPosition Position
        {
            get { return _position; }
        }

        /// <summary>
        ///     Gets converted positions of account
        /// </summary>
        /// <returns></returns>
        public static IList<AvgPositionListEntry> ConvertFromOecAvgPositionList()
        {
            return
                //ListConverter<Position, AvgPositionListEntry>.FromIEnumerable(
                //    OECClient.Global.Accounts.First.AvgPositions, AvgPositionListConverter);
                ListConverter<IPosition, AvgPositionListEntry>.FromIEnumerable(
                    Globals.CurrentAccountOrAB.AvgPositions, AvgPositionListConverter);

        }

        /// <summary>
        ///     Converts native position to position list entry
        /// </summary>
        private static AvgPositionListEntry AvgPositionListConverter(IPosition position)
        {
            return new AvgPositionListEntry(position);
        }
    }
}