using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace BankSystemPrototype
{
    class AccountTransactions<T>
        where T : Account
    {
        /// <summary>
        /// Добавить деньги на счет
        /// </summary>
        /// <param name="count">кол-во пересылаемых денег</param>
        /// <param name="i"> индекс i</param>
        /// <param name="j">индекс j</param>
        public void AddMoney(long count, int i, int j, Action<string> action, string str)
        {
            var user = UserDataBase.users[i];
            user.Accounts[j].Cash += count;

            action?.Invoke(str);
        }

        /// <summary>
        /// Перевод денег другому человеку
        /// </summary>
        /// <param name="send">Индекс того, кто посылает</param>
        /// <param name="recieveBox">Лист получателей</param>
        /// <param name="i"> индекс аккаунта</param>
        /// <param name="count"> кол-во денег</param>
        public void TransferMoney(int send, ListView recieveBox, int i, long count, Action<string> message, string str)
        {
            if (recieveBox.SelectedIndex == -1)
            {
                return;
            }
            var sender = UserDataBase.users[send];
            var recipient = UserDataBase.GetUsersByListView(recieveBox);
   
            IEnumerable<Account> recip = recipient.Accounts.Where(x => x is T && !x.isClosed);

            if (recip.Count() == 0)
            {
                RejectionByAccount(recipient.Name);
                return;
            }

            foreach (var cash in recip)
            {
                if (count > sender.Accounts[i].Cash)
                {
                    RejectionByMoney();
                    return;
                }
                if (cash.isClosed)
                {
                    RejectionByAccount(recipient.Name);
                    return;
                }
                cash.Cash += count;
                sender.Accounts[i].Cash -= count;

                message?.Invoke(str);
               
            }
           

          
        }
        /// <summary>
        /// Перевод средств внутри аккаунта
        /// </summary>
        /// <param name="count">кол-во денег</param>
        /// <param name="send">Индекс выбранного человека</param>
        /// <param name="accountType">Вид аккаунта</param>
        public void TransferMoneyInAccount(long count, int send, Type accountType, Action<string> message, string str)
        {
            var user = UserDataBase.users[send];
            var index = user.Accounts.FindIndex(i => i is T);

            IEnumerable<Account> recip = user.Accounts.Where(x => x.GetType() == accountType);

            if (recip.Count() == 0 )
            {
                RejectionByAccount(user.Name);
                return;
            }

            foreach (var minusAccount in recip)
            {
                if (index < 0 || minusAccount.isClosed)
                {
                    RejectionByAccount(user.Name);
                    return;
                }

                if (count > minusAccount.Cash)
                {
                    RejectionByMoney();
                    return;
                }

                var account = user.Accounts[index];

                if (account.isClosed)
                {
                    RejectionByAccount(user.Name);
                    return;
                }
                minusAccount.Cash -= count;
                
                account.Cash += count;
                message?.Invoke(str);
            }
             
        }
       private void RejectionByAccount(string user)
        {
                MessageBox.Show($"У {user} нет Недепозитного счета.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public void RejectionByMoney()
        {
            MessageBox.Show($"У вас недостаточно денег.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

    }
}
