using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek6_ContoBanca
{
    public abstract class Movimento
    {
        public decimal Importo { get; set; }
        public DateTime Data { get; set; }

        public override string ToString()
        {
            return $"{Importo,10}{Data,20}" ;
        }
    }
}
