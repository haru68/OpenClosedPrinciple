using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public sealed class Factory
    {
        public Production Craft(IEnumerable<ICraftable> craftables)
        {
            Production newProduction = new Production(craftables);
            return newProduction;
        }
    }
}
