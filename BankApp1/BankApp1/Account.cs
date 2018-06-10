using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp1
{
    class Account
    {
        #region
        /// <summary>
        /// Unique account number for the account
        /// </summary>
        public int AccountNumber { get; private set; }
        /// <summary>
        /// Email address of 
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Account Current Balance
        /// </summary>
        public decimal Balance { get; private set; }
        /// <summary>
        /// Account type
        /// </summary>
        public string TypeOfAccount { get; set; }
        /// <summary>
        /// Create date of the Account
        /// </summary>
        public DateTime dateTime { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Deposit Amount
        /// </summary>
        /// <param name="amount">Amount to deposit</param>
        /// <returns>updated balance</returns>
        public decimal Deposit(decimal amount)
        {
            Balance += amount;
            return Balance;
        }
        /// <summary>
        /// Withdraw amount
        /// </summary>
        /// <param name="amount">amount to withdraw</param>
        /// <returns>updated balance</returns>
        public decimal Withdraw(decimal amount)
        {
            Balance -= amount;
            return Balance;
        }
        #endregion

    }
}
