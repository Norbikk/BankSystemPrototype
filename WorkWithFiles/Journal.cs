using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemPrototype
{
    class Journal
    {
        /// <summary>
        /// Записывает в txt файл
        /// </summary>
        /// <param name="str">Записанный текст</param>
        public static void WriteInJournal(string str)
        {         
            var streamWriter = new StreamWriter("journal.txt", true);
            streamWriter.WriteLine(str);
            
            streamWriter.Close();
        }

        /// <summary>
        /// Метод делегата
        /// </summary>
        /// <param name="message"></param>
        public static void PostMessage(string message)
        {
            WriteInJournal(message);
        }

    }
}
