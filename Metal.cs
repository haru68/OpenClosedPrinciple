using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class Metal : ICraftable
    {
        public string Type
        {
            get
            {
                return "Metal";
            }
        }
    }
}
