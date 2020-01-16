using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public interface ICurrencyForm
    {
        void SetController(CurrencyConverterController controller);
        
        ListView CurrencyListView { get; }
        ComboBox ComboBoxFrom { get; }

        ComboBox ComboBoxTo { get; }

        void ConversionValue(string Value);

    }
}
