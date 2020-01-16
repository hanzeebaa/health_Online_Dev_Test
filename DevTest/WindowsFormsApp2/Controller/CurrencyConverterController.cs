using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp2
{
    public class CurrencyConverterController
    {
        ICurrencyForm currencyForm;

        string port1 = "44374";
        string port2 = "44382";
        string params1 = "Currency";
        string params2 = "Exchange";
        string providerURL = "https://localhost:";
        string providerAPI = "/api/v1/";
        List<CurrencyConverterModel> currencies = new List<CurrencyConverterModel>();
        bool provider1Selected = true;
        string currencyFrom;
        string currencyTo;
        double enteredValue;

        public static CurrencyConverterController Create(ICurrencyForm form1)
        {
            return new CurrencyConverterController(form1);
        }
        internal CurrencyConverterController(ICurrencyForm Form)
        {
            currencyForm = Form;
            currencyForm.SetController(this);
        }

        public void LoadView()
        {
            RetrieveProvider1Values();
            RetrieveProvider2Values();
            foreach (CurrencyConverterModel ccm in currencies)
            {
                if (!ccm.FullName.Equals("GBP - British Pound"))
                {
                    ListViewItem item = new ListViewItem(new[]
                                                        { ccm.FullName, ccm.Provider1Rate.ToString(),ccm.Provider2Rate.ToString()});


                    currencyForm.CurrencyListView.Items.Add(item);
                }

                currencyForm.ComboBoxFrom.Items.Add(ccm.FullName);
                currencyForm.ComboBoxTo.Items.Add(ccm.FullName);
            }
            
        }

        public void EnteredValue(string amountRequired)
        {
            //TODO parse to int and exception check
            
            try
            {
                enteredValue = Convert.ToDouble(amountRequired);
            }
            catch
            {

            }
        }

        public bool Provider1Selected
        {
            set
             {
                provider1Selected = value;
            }
        }

        public string ConvertCurrencyFromValue
        {
            set
            {
                currencyFrom = value;
            }
        }

        public string CurrencyToValue
        {
            set
            {
                currencyTo = value;
            }
        }

        private void RetrieveProvider1Values()
        {
            DataReturnedObjectCurrency[] Provider1Values = JsonConvert.DeserializeObject< DataReturnedObjectCurrency[]>( GetData(string.Format("{0}{1}", providerURL, port1), string.Format("{0}{1}", providerAPI, params1)));
            foreach (DataReturnedObjectCurrency obj in Provider1Values)
            {
                CurrencyConverterModel value = new CurrencyConverterModel()
                {
                    FullName = string.Format("{0} - {1}", obj.IsoName, obj.CurrencyName),
                    Provider1Rate = obj.CurrencyRate
                };

                currencies.Add(value);
            }
        }

        private void RetrieveProvider2Values()
        {
            DataReturnedObjectExchange[] Provider2Values = JsonConvert.DeserializeObject<DataReturnedObjectExchange[]>(GetData(string.Format("{0}{1}", providerURL, port2), string.Format("{0}{1}", providerAPI, params2)));
            foreach (DataReturnedObjectExchange obj in Provider2Values)
            {
                foreach (CurrencyConverterModel ccm in currencies)
                {
                    if (ccm.FullName.Equals(string.Format("{0} - {1}", obj.Iso, obj.Name)))
                    {
                        ccm.Provider2Rate = obj.Rate;
                        break;
                    }
                }
            }
        }


        private string GetData(string currencyURL, string currencyParams)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(currencyURL);

                HttpResponseMessage response = client.GetAsync(currencyParams).Result;  
                if (response.IsSuccessStatusCode)
                {                    
                    var dataObjects = response.Content.ReadAsStringAsync();
                    string data = dataObjects.Result;
                    return data;
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                    return null;
                }
            }
        }

        public void DoConversion()
        {
            if (enteredValue > 0 && currencyTo != null && currencyFrom != null)
            {
                string outputValue = string.Empty;
                if (currencyFrom.Equals(currencyTo))
                {
                    outputValue = Convert.ToString(enteredValue);
                }
                else
                {
                    double to = 0.0, from = 0.0;

                    foreach (CurrencyConverterModel ccm in currencies)
                    {

                        if (ccm.FullName == currencyTo)
                        {
                            to = provider1Selected ? ccm.Provider1Rate : ccm.Provider2Rate;
                        }
                        if(ccm.FullName == currencyFrom)
                        {
                            from = provider1Selected ? ccm.Provider1Rate : ccm.Provider2Rate;
                        }
                    }

                    double result = enteredValue / from * to;

                    result = Math.Round(result, 2, MidpointRounding.AwayFromZero);
                    outputValue = Convert.ToString(result);
                }
                currencyForm.ConversionValue(outputValue);
            }
        }

    }
}
