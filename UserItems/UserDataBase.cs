using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BankSystemPrototype
{
    class UserDataBase
    {
        public static ObservableCollection<User> users { get; set; } = new();

        public static User GetUsersByListView(ListView listView)
        {
            var user = new User();
            for (int j = 0; j < users.Count; j++)
            {
                if (listView.SelectedItem == users[j])
                {
                  user = users[j];
                }
            }
            return user ;
        }
    }
}
