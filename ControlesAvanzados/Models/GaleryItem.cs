using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesAvanzados.Models
{
    public class GaleryItem : INotifyPropertyChanged
    {
        public string Url { get; set; }
        public int Score { get; set; }

        private string date;

        public string Date
        {
            get { return date; }
            set { date = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Date"));
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
    }
}
