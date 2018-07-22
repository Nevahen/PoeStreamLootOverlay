using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PoEStreamLootOverlay
{
    public class Currency: INotifyPropertyChanged
    {

        public string Name { get; set; }
        public string Icon { get; set; }
        bool Enabled;

        public event PropertyChangedEventHandler PropertyChanged;

        private int _count;
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value != _count)
                {
                    _count = value;
                    NotifyPropertyChanged();
                    ImageBuilder.Instance.MakeImage(CurrencyList.currencyList);
                }
            }
        }


        public Currency(string name, string icon){
            Count = 1;
            Name = name;
            Icon = icon;
        }

        public void Increase()
        {
            Count++;
        }

        public void Decrease()
        {
            if(Count > 0) { 
            Count--;
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
