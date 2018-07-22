using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PoEStreamLootOverlay
{
    public partial class CustomResources : ResourceDictionary
    {
        public void ButtonIncrease(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var currency = btn.Tag as Currency;

            currency.Increase();
        }

        public void ButtonDecrease(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var currency = btn.Tag as Currency;

            currency.Decrease();
        }
    }
}
