using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek6_ContoBanca
{
    public static class MenuManager
    {

        public static ContoCorrente conto = new ContoCorrente();
        public static List<Movimento> Movimenti = new List<Movimento>();

        public static void NuovoAccount()
        {
            Console.WriteLine("NUOVO ACCOUNT");
            Console.WriteLine();

            Console.WriteLine("In quale Banca vuoi aprire il conto corrente?");
            conto.Banca = Console.ReadLine();
            Console.WriteLine("Inserisci l'importo del primo versamento:");
            bool isDecimal = decimal.TryParse(Console.ReadLine(), out decimal importo);
            while (!(isDecimal && importo > 0))
            {
                Console.WriteLine("Inserimento non valido!");
                Console.WriteLine("Inserisci l'importo del primo versamento:");
                isDecimal = decimal.TryParse(Console.ReadLine(), out importo);
            }
            conto.Saldo = importo;

        }

        public static void MostraDatiConto()
        {
            Console.WriteLine("{0,10}{1,20}{2,20}{3,30}", "Numero", "Banca", "Saldo", "Ultima Operazione");

            Console.WriteLine(new String('-', 80));
            Console.WriteLine("{0,10}{1,20}{2,20}{3,30}", conto.Numero, conto.Banca, conto.Saldo, conto.UltimaOperazione);
            Console.WriteLine(new String('-', 80));

        }

        public static void MostraTransazioni()
        {
            Console.WriteLine("{0,10}{1,20}", "Importo", "Data");
            foreach (Movimento movimento in Movimenti)
            {
                Console.WriteLine(movimento);
            }
        }

        public static int ScegliTransazione()
        {
            Console.WriteLine("Che tipo di transazione vuoi fare?");

            Console.WriteLine("1: Cash Movement");
            Console.WriteLine("2: Transfert Movement");
            Console.WriteLine("3: Credit Card Movement");
            Console.Write(">> ");
            bool isCorrect = int.TryParse(Console.ReadLine(), out int index);
            while (!(isCorrect && index >= 1 && index <= 3))
            {
                Console.WriteLine("Scelta non disponibile!");
                Console.WriteLine("Che tipo di transazione vuoi fare?");
                isCorrect = int.TryParse(Console.ReadLine(), out index);

            }
            return index;

        }

        public static void NuovoCashMovement()
        {
            CashMovement movimento = new CashMovement();
            Console.WriteLine("Vuoi versare o prelevare?");
            Console.WriteLine("1: Versare\n2:Prelevare");
            bool isOk = int.TryParse(Console.ReadLine(), out int choice);
            while (!(isOk && choice >= 1 && choice <= 2))
            {
                Console.WriteLine("Scelta errata!");
                Console.WriteLine("1: Versare\n2:Prelevare");
                isOk = int.TryParse(Console.ReadLine(), out choice);
            }
            Console.WriteLine("Inserisci importo:");
            bool isDecimal = decimal.TryParse(Console.ReadLine(), out decimal importo);
            while (!isDecimal && importo > 0)
            {
                Console.WriteLine("Inserimento non valido!");
                Console.WriteLine("Inserisci importo:");
                isDecimal = decimal.TryParse(Console.ReadLine(), out importo);
            }
            if (choice == 2)
            {
                if (conto.Saldo >= importo)
                {
                    movimento.Importo = importo;
                }
                else
                {
                    throw new SaldoInsufficienteException("Saldo Insufficiente!");
                }
            }
            else movimento.Importo = importo;


            movimento.Data = DateTime.Now;
            Console.WriteLine("Inserisci esecutore: ");
            string esecutore = Console.ReadLine();
            movimento.Esecutore = esecutore;

            Movimenti.Add(movimento);
        }

        public static void NuovoCreditCardMovement()
        {

        }

        public static void NuovoTransfertMovement()
        {

        }


    }
}
