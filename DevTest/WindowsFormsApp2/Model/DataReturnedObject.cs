using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class DataReturnedObjectCurrency
    {
        public string IsoName { get; set; }
        public string CurrencyName { get; set; }
        public double CurrencyRate { get; set; }
    }

    public class DataReturnedObjectExchange
    {
        public string Iso { get; set; }
        public string Name { get; set; }
        public double Rate { get; set; }
    }
}