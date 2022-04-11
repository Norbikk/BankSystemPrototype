
using System;

namespace BankSystemPrototype
{
    
    public abstract class Account
    {
        public Guid AccountNumber { get; set; }
        public long Cash { get; set; }
        public bool isClosed = false;

        /// <summary>
        /// Метод создания номера счета
        /// </summary>
        /// <returns></returns>
        public Account CreateAccount()
        {
            AccountNumber = Guid.NewGuid();
            Cash = 0;
            return this;
        }

        public abstract string GetInfo();

        /// <summary>
        /// Метод закрытия счета
        /// </summary>
        public void Close()
        {
            isClosed = true;
        }
        
    }
}
