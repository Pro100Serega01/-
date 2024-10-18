using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛАБ2_1
{
    public class Basic_Class
    {
        protected bool field1, field2;
        public Basic_Class(bool field1, bool field2) 
        {
            this.field1 = field1;
            this.field2 = field2;   
        }
        public Basic_Class(Basic_Class other)
        {
            this.field1 = other.field1;
            this.field2 = other.field2;
        }
        public bool CalculateConjunction() 
        { 
            return field1 && field2; 
        }
        public override string ToString()
        {
            return $"field1 = {field1}, field2 = {field2}";
        }
    }
}
