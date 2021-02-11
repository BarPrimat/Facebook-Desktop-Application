using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.Logic.Facade
{
    public interface Analyzer
    {
        void Analyzer();

        Dictionary<string, int> PatternAndThereAmountDictionary { get;}
    }
}
