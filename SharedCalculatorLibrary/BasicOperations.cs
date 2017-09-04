using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCalculatorLibrary
{
    public class BasicOperations
    {

        /// <summary>
        /// 2 properties tal 1 og tal 2 af datatypen double så decimaler er muligt.
        /// </summary>
        public double Tal1 { get; set; }
        public double Tal2 { get; set; }

        /// <summary>
        /// Metode som er void hvori tal1 og tal 2 props plusses med hinanden. 
        /// </summary>

        public double PlusFunktion()
        {
            return (Tal1 + Tal2);          
        }

        /// <summary>
        /// Metode som er void hvori tal1 og tal 2 props minus hinanden. 
        /// </summary>

        public double MinusFunktion()
        {
            return (Tal1 - Tal2);
        }

        /// <summary>
        /// Metode som er void hvori tal1 og tal 2 props ganges med hinanden. 
        /// </summary>

        public double GangeFunktion()
        {       
           return (Tal1 * Tal2);         
        }

        /// <summary>
        /// Metode som er void hvori tal1 og tal 2 props divideret med hinanden. 
        /// </summary>

        public double DividerFunktion()
        {
            return (Tal1 / Tal2);         
        }


        public BasicOperations(double tal1, double tal2)
        {
            this.Tal1 = tal1;
            this.Tal2 = tal2;
        }
    }
}
