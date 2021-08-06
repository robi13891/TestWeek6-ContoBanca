using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek6_ContoBanca.Entities
{
    public class CreditCardMovement : Movimento
    {
        public string NumeroCarta { get; set; }
        public Tipo Circuito { get; set; }


        public enum Tipo
        {
            Amex,
            Visa,
            MasterCard,
            Altro

        }
    }
}




