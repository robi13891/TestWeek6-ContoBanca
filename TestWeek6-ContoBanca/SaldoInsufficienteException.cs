using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek6_ContoBanca
{
    public class SaldoInsufficienteException : Exception
    {
        public SaldoInsufficienteException()
        {
        }

        public SaldoInsufficienteException(string message) : base(message)
        {
        }
    }
}
