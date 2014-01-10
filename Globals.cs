using System.IO;
using System.Reflection;
using OEC.Data;

namespace OEC.API.Example
{
    /// <summary>
    ///     Global objects
    /// </summary>
    internal class Globals
    {
        /// <summary>
        ///     Allocation blocks storage file name
        /// </summary>
        public static readonly string ABSavesFileName =
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\AllocationBlocks.xml";


        private static AccountOrAB _currentAccountOrAB;

        /// <summary>
        ///     Current account or allocation block
        /// </summary>
        public static AccountOrAB CurrentAccountOrAB
        {
            get { return _currentAccountOrAB; }
            set
            {
                _currentAccountOrAB = value;
                if (OnCurrentAccountChanged != null)
                {
                    OnCurrentAccountChanged(_currentAccountOrAB);
                }
            }
        }


        public delegate void CurrentAccountChanged(AccountOrAB accountOrAB);
        /// <summary>
        ///     Occurs when current account or allocation block changed
        /// </summary>
       // public static event OnBalanceChangedEvent OnCurrentAccountChanged;
       public static event CurrentAccountChanged OnCurrentAccountChanged;

        /// <summary>
        ///     Sets current account or allocation block to order draft
        /// </summary>
        /// <param name="draft">Order draft for which to set current account or allocation block</param>
        public static void SetDraftAccount(OrderDraft draft)
        {
            Account curAccount = null;
            var accountType = AccountType.Customer;
            if (draft.CustomCompound != null || draft.Contract.IsEquityAsset)
                accountType = AccountType.Equity;
            else if (draft.Contract.BaseContract.ContractKind == ContractKind.Forex)
                accountType = AccountType.StandardFX;
            foreach (Account account in OECClient.Global.Accounts)
            {
                if (account.Type == accountType)
                {
                    curAccount = account;
                    break;
                }
            }

            draft.Account = curAccount;

            var currentAccount = CurrentAccountOrAB.Account;
            if (currentAccount != null)
            {
                draft.Account = currentAccount;
                draft.AllocationBlock = null;
            }
            var currentAB = CurrentAccountOrAB.AllocationBlock;
            if (currentAB != null)
            {
                draft.Account = null;
                draft.AllocationBlock = currentAB;
            }
        }
    }
}