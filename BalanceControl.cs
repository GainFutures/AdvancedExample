using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace OEC.API.Example
{
    /// <summary>
    ///     Balance control. Visualizes account summary
    /// </summary>
    public partial class BalanceControl : BaseControl
    {
        /// <summary>
        ///     Balance control constructor
        /// </summary>
        public BalanceControl()
        {
            InitializeComponent();
            NullAllIndicators();
        }

        /// <summary>
        ///     Prepares balance event handlers
        /// </summary>
        protected override void PrepareControlEventHandlers()
        {
            OECClient.Global.OnAccountSummaryChanged += OECClient_OnAccountSummaryChanged;
            OECClient.Global.OnBalanceChanged += OECClient_OnBalanceChanged;

            Globals.OnCurrentAccountChanged += Globals_OnCurrentAccountChanged;
            UpdateBalance(Globals.CurrentAccountOrAB);
        }

        /// <summary>
        ///     Occurs when current account changed
        /// </summary>
        private void Globals_OnCurrentAccountChanged(AccountOrAB accountOrAB)
        {
            UpdateBalance(accountOrAB);
        }

        /// <summary>
        ///     Refresh balance control when account summary is changed
        /// </summary>
        private void OECClient_OnAccountSummaryChanged(Account account, Currency currency)
        {
            UpdateBalance(new AccountOrAB(account));
        }

        /// <summary>
        ///     Called when ballance required to be updated
        /// </summary>
        private void OECClient_OnBalanceChanged(Account account, Currency currency)
        {
            UpdateBalance(new AccountOrAB(account));
        }

        /// <summary>
        ///     Update Ballance Control
        /// </summary>
        private void UpdateBalance(AccountOrAB accountOrAB)
        {
            if (Globals.CurrentAccountOrAB == accountOrAB || Globals.CurrentAccountOrAB.HasAccount(accountOrAB.Account))
            {
                Balance balance = accountOrAB.TotalBalance;
                if (balance == null)
                {
                    NullAllIndicators();
                    return;
                }
                SetActiveText(lbOpenPL, balance.OpenPnL);
                SetActiveText(lbRealizedPL, balance.RealizedPnL);
                SetActiveText(lbTotalPL, balance.OpenPnL + balance.RealizedPnL);

                SetActiveText(lbNetLiq, balance.NetLiquidatingValue - balance.SettlePnL + balance.OpenPnL);
                SetActiveText(lbCash, balance.NetLiquidatingValue - balance.SettlePnL);
            }
        }

        /// <summary>
        ///     Clears all indicators
        /// </summary>
        private void NullAllIndicators()
        {
            lbNetLiq.Text = lbOpenPL.Text = lbRealizedPL.Text = lbTotalPL.Text = string.Empty;
        }

        /// <summary>
        ///     Sets values to indicators with appropriate color (green when positive, red when negative, black when zero
        /// </summary>
        /// <param name="lb">Indicator (Label control) on which to make changes </param>
        /// <param name="value">Value which to set into indicator</param>
        private void SetActiveText(Label lb, double value)
        {
            lb.ForeColor = (value < 0) ? Color.Red : ((value > 0) ? Color.Green : Color.Black);

            var nfo = new NumberFormatInfo {CurrencySymbol = string.Empty};
            lb.Text = value.ToString("C", nfo);
        }
    }
}