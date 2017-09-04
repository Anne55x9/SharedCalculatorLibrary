using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCalculatorLibrary
{
    public class BasicOperations
    {
        public double tal1 { get; set; }
        public double tal2 { get; set; }

        private void PlusFunktion()
        {
            (tal1 + tal2).ToString();           
        }

        private void MinusFunktion()
        {         
            (tal1 - tal2).ToString();
        }

        private void GangeFunktion()
        {       
            (tal1 * tal2).ToString();         
        }

        private void DividerFunktion()
        {       
           (tal1 / tal2).ToString();         
        }
    }
}
