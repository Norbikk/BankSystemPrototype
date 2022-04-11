using System.Collections.ObjectModel;
using System.IO;
using Newtonsoft.Json;

namespace BankSystemPrototype
{
    class WorkWithJSON 
    {
        /// <summary>
        /// Сериализация в JSON файл
        /// </summary>
        public void DatabaseToJson(ObservableCollection<User> what, string where)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            var jsonString = JsonConvert.SerializeObject(what, Formatting.Indented, settings);
            var streamWriter =
                new StreamWriter(where); //Запускаем стримрайтер для записи\дозаписи\создания
            streamWriter.WriteLine(jsonString); //Записываем в документ
            streamWriter.Close(); //Закрываем документ
        }

        /// <summary>
        /// Десереализация из JSON файла
        /// </summary>
        public static ObservableCollection<User> DeserializePersonJson(string where)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            ObservableCollection<User> what = new();
            if (File.Exists(where))
            {
                string jsonString = File.ReadAllText(where);
                
                what = JsonConvert.DeserializeObject<ObservableCollection<User>>(jsonString, settings);
                
            }

            return what;
        }
    }
}
