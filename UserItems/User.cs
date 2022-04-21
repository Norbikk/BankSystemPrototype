using System;
using System.Collections.Generic;

namespace BankSystemPrototype
{
    class User
        
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Secondname { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDay { get; set; }
        public List<Account> Accounts { get; set; } = new List<Account>();


        public User()
        {

        }

        public event Action<string> Post;

        /// <summary>
        /// Вызывает делегат для передачи информации по созданию юзера
        /// </summary>
        public void CreateUserMessage()
        {
            User user = this;

            Post?.Invoke($"{DateTime.Now} Открыт новый счет. Имя: {user.Name} Фамилия: {user.Surname}" +
                $" Отчество: {user.Secondname} Номер телефона: {user.PhoneNumber} Дата рождения: {user.BirthDay}");
        }

        /// <summary>
        /// Вызывает делегат передачи информации счета
        /// </summary>
        public void CloseAccountMessage()
        {
            User user = this;
            Post?.Invoke($"{DateTime.Now} Счет пользователя {user.Surname} {user.Name} был закрыт");
        }

        /// <summary>
        /// Вызывает делегат для передачи информации по пересылу денежных средств
        /// </summary>
        /// <param name="reciever"></param>
        /// <param name="count"></param>
        public void MoneyTransaction(User reciever, long count)
        {
            User sender = this;
            Post?.Invoke($"{DateTime.Now} {sender.Surname} {sender.Name} перевел {count} на счет {reciever.Surname} {reciever.Name}");
        }
        /// <summary>
        /// Вызывает делегат для передачи информации по пополнению счета
        /// </summary>
        /// <param name="count"></param>
        public void PutMoneyMessage(long count)
        {
            User user = this;
            Post?.Invoke($"{DateTime.Now} {user.Surname} {user.Name} пополнил счет на {count}");
        }
        /// <summary>
        /// Вызывает делегат для передачи информации по транзакциям Депозитного счета
        /// </summary>
        /// <param name="count"></param>
        /// <param name="account"></param>
        public void TransferMoneyInDeposit(long count, string account)
        {
            User user = this;
            Post?.Invoke($"{DateTime.Now} {user.Surname} {user.Name} пополнил {account} счет на {count}");
        }
        public override string ToString() => $"{Surname} {Name} {Secondname}";

    }
}
