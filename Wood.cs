using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class Wood : ICraftable
    {
        public string Type
        {
            get
            {
                return "Wood";
            }
        }
    }
}
