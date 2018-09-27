using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList_with_IComparer

{
    class PrimeMinister
    {
        public string Name  { get; set; }
        public int YearElected { get; set; }

        public PrimeMinister(string name, int yearElected)
        {
            this.Name = name;
            this.YearElected = yearElected;
        }

        public override string ToString()
        {
            return String.Format("{0}, elected {1}", Name, YearElected);
        }
    }
}
