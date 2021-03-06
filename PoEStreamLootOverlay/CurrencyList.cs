﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PoEStreamLootOverlay
{
    public class CurrencyList
    {

        public static Dictionary<string, Currency> currencyList = new Dictionary<string, Currency>();
                
        public CurrencyList()
        {

            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Assets\");

            Currency tmpCur = new Currency("Exalted Orb", path + "exalt.png");
            Currency tmpCur2 = new Currency("Divine Orb", path + "divine.png");
            Currency tmpCur3 = new Currency("Annulment Orb", path + "annul.png");
            Currency tmpCur4 = new Currency("Chaos Orb", path + "chaos.png");

            currencyList.Add(tmpCur.Name, tmpCur);
            currencyList.Add(tmpCur2.Name, tmpCur2);
            currencyList.Add(tmpCur3.Name, tmpCur3);
            currencyList.Add(tmpCur4.Name, tmpCur4); 
        }

        public void Reset()
        {
            foreach(Currency item in currencyList.Values)
            {
                item.Count = 0;
            }
        }
    }

}


