using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApptextboxvalidattion
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public string ProductName
        {
            get { return productName; }
            set
            {
                productName = value;
                if (productName == "")
                {
                    productNameChecker = "Visible";
                }
                else
                {
                    productNameChecker = "Collapsed";

                }
                OnPropertyChanged(nameof(productNameChecker));
            }
        }
        public ICommand SaveMenuCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string productName;

        private string productNamechecker { get; set; }

        public string productNameChecker { get; set; }



    }

   
}
