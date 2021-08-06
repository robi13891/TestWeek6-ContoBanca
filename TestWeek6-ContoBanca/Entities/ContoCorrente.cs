using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek6_ContoBanca
{
    public class ContoCorrente
    {
        public string Numero { get; set; }
        public string Banca { get; set; }

        public decimal Saldo { get; set; }
        public DateTime UltimaOperazione { get; set; }

        public List<Movimento> StoricoMovimenti { get; set; }

        public ContoCorrente()
        {
            Numero = "000123";
            UltimaOperazione = DateTime.Now;
        }

    }
}
