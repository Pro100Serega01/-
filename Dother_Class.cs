using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛАБ2_1
{
    class Dother_Class : Basic_Class
    {
        private string name;

        // Конструктор
        public Dother_Class(bool field1, bool field2, string name) : base(field1, field2)
        {
            this.name = name;
        }

        // Метод для получения информации о классе
        public string GetInfo()
        {
            return $"{name}: {ToString()}";
        }

        // Метод проверки
        public bool Check2field()
        {
            return field1 && field2;
        }
    }
}
