using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoEStreamLootOverlay
{
    public static class Logger
    {
        public static void Dump(this object obj)
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(obj,Formatting.None, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            }));
        }
    }
}
