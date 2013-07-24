using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OEC.API;
using OEC.Data;

namespace TraderLight
{
    public partial class DetailedPositionsControl : TraderLight.BaseControl
    {
        public DetailedPositionsControl()
        {
            InitializeComponent();
        }

        protected override void PrepareControlEventHandlers()
        {
            base.PrepareControlEventHandlers();
            OECClient.Global.OnLoginComplete += new OnLoginCompleteEvent(OnLoginComplete);
            OECClient.Global.OnDetailedPositionChanged += new OnPositionChangedEvent(OnDetailedPositionChanged);
        }


        void OnDetailedPositionChanged(Account Account, Position ContractPosition)
        {
            UpdateDetailedPositions();
        }

        void OnLoginComplete()
        {
            UpdateDetailedPositions();
        }

        BindingSource positionsBindingSource = new BindingSource();
        private void UpdateDetailedPositions()
        {

            IList<DetPositionListEntry> positionList = DetPositionListEntry.ConvertFromOECDetPositionList();
            positionsBindingSource.DataSource =  positionList;
            dgDetPositions.DataSource = positionsBindingSource;
        }

        /// <summary>
        /// Closes position
        /// </summary>
        private void btExitPosition_Click(object sender, EventArgs e)
        {
            if (positionsBindingSource.Current == null)
                return;

            DetPositionListEntry pos = (DetPositionListEntry)positionsBindingSource.Current;

            NewOrderDraft draft = OECClient.Global.CreateDraft();

            draft.Account = pos.GetPosition().Account;
            draft.Side = (pos.GetPosition().Net.Volume < 0) ? OrderSide.Buy : OrderSide.Sell;
            draft.Contract = pos.GetPosition().PositionContract;
            draft.Quantity = Math.Abs(pos.GetPosition().Net.Volume);
            draft.Type = OrderType.Market;
            if (MessageBox.Show("Send " + draft.ToString()+ " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No)
                return;
            OECClient.Global.SendOrder(draft);

        }
    }

    /// <summary>
    /// Used for simple representation of detailed positions
    /// </summary>
    class DetPositionListEntry
    {
        
        public string Contract
        {
            get { return m_position.Contract.ToString(); }
        }

        public Contract ID
        {
            get { return m_position.ID; }
        }

        public string BoughtAvgPrice
        {
            get { return m_position.Contract.PriceToString(m_position.Long.Price); }
        }

        public string SoldAvgPrice
        {
            get { return m_position.Contract.PriceToString(m_position.Short.Price); }
        }

        public double Amount
        {
            get { return m_position.Net.Volume; }
        }

        public string TotalPnL
        {
            get { return m_position.Contract.PriceToString(m_position.Gain); }
        }

        public string RealizedPnL
        {
            get { return m_position.Contract.PriceToString(m_position.NetGain); }
        }

        public string OpenPnL
        {
            get { return  m_position.Contract.PriceToString(m_position.OTE); }
        }

        private Position m_position;
        public Position GetPosition()
        {
            return m_position;
        }

        private DetPositionListEntry(Position position)
        {
            m_position = position;
        }

        public static IList<DetPositionListEntry> ConvertFromOECDetPositionList()
        {
            DetailedPositionList positionLists = OECClient.Global.Accounts.First.DetailedPositions;
            return ListConverter<OEC.API.Position, DetPositionListEntry>.FromIEnumerable(GetAllPositions(positionLists), DetPositionListConverter);
        }
        
        private static DetPositionListEntry DetPositionListConverter(OEC.API.Position position)
        {
            return new DetPositionListEntry(position);
        }

        private static IEnumerable<Position> GetAllPositions(DetailedPositionList positionLists)
        {
            foreach (PositionList pl in positionLists)
            {
                foreach (Position p in pl)
                {
                    yield return p;
                }
            }
        }
    }
}

