using System;
using System.Collections.Generic;
using System.Text;

namespace OEC.API.Example
{

    public class AccountOrAB
    {
        public Account Account
        {
            get;
            set;
        }

        public AllocationBlock AllocationBlock
        {
            get;
            set;
        }

        public AccountOrAB(Account account)
            : this(account, null)
        {
            
        }

        public AccountOrAB(AllocationBlock allocationBlock)
            : this(null, allocationBlock)
        {
        }

        private AccountOrAB(Account account, AllocationBlock block)
		{
            Account = account;
			AllocationBlock = block;
        }

        public Balance TotalBalance
        {
            get
            {
                return Account != null ? Account.TotalBalance : AllocationBlock.TotalBalance;
            }
        }

        public IEnumerable<IPosition> AvgPositions
        {
            get
            {
                if (AllocationBlock != null)
                    foreach (IPosition pos in AllocationBlock.AvgPositions)
                        yield return pos;
                else
                {
                    foreach (IPosition pos in Account.AvgPositions)
                        yield return pos;
                }
            }
        }

        public IEnumerable<Account> AllAccounts
        {
            get
            {
                if (Account != null)
                    yield return Account;
                else
                {
                    foreach (AllocationBlockItem blockItem in AllocationBlock.Items)
                        yield return blockItem.Account;
                }
            }
        }

        public bool HasAccount(Account account)
        {
            bool result = false;
            foreach (var a in AllAccounts)
            {
                if (account == account)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }


        public override string ToString()
        {
            return Account != null ? Account.ToString() : AllocationBlock.ToString();
        }
    }
}
