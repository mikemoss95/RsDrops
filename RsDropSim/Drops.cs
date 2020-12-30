using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RsDropSim
{
    public class Drops
    {
        public string Item { get; set; }
        public uint Value { get; set; }

        public Drops(string itemName, uint itemValue)
        {
            Item = itemName;
            Value = itemValue;
        }

        public Drops(string itemName)
        {
            Item = itemName;
        }
    }

}
