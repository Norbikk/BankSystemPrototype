
using System.Text.Json.Serialization;


namespace BankSystemPrototype
{
   public class NonDepositeAccount : Account
    {

        /// <summary>
        /// Возвращает наименование Счета
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            var str = "Недепозитный аккаунт";
            return isClosed ? $"{str} [ЗАКРЫТ]" : str;
        }
    }
}
