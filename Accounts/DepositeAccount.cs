

namespace BankSystemPrototype
{
    public class DepositeAccount : Account
    {

        /// <summary>
        /// Возвращает наименование Счета
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            var str = "Депозитный аккаунт";
            return isClosed ? $"{str} [ЗАКРЫТ]" : str;
        }
    }
}
