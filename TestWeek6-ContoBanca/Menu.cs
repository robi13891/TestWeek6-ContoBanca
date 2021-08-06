using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek6_ContoBanca
{
    public static class Menu
    {
        public static void Start()
        {
            MenuManager.NuovoAccount();

            bool keepOnGoing = true;
            do
            {
                
                Console.Clear();                
                Console.WriteLine("MENU CONTO");
                Console.WriteLine();                
               
                Console.WriteLine("1: Nuovo Movimento ");
                Console.WriteLine("2: Mostra Dati Conto");
                Console.WriteLine("3: Mostra Transazioni Conto");
                Console.WriteLine("4: Esci");
                Console.WriteLine();
                Console.Write(">> ");
                bool isInt = int.TryParse(Console.ReadLine(), out int indexMenu);
                while (!isInt)
                {
                    Console.WriteLine("Scelta non valida!");
                    Console.Write(">> ");
                    isInt = int.TryParse(Console.ReadLine(), out indexMenu);
                }

                switch (indexMenu)
                {
                    case 1:
                        Console.Clear();
                        int index = MenuManager.ScegliTransazione();
                        if(index == 1)
                        {
                            MenuManager.NuovoCashMovement();
                        }
                        else if(index == 2)
                        {
                            MenuManager.NuovoTransfertMovement();
                        }
                        else if (index == 3)
                        {
                            MenuManager.NuovoCreditCardMovement();
                        }
                        
                        Console.WriteLine();
                        Console.Write("Premi un tasto\n>> ");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        MenuManager.MostraDatiConto();
                        Console.WriteLine();
                        Console.Write("Premi un tasto\n>> ");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        // codice
                        Console.WriteLine();
                        Console.Write("Premi un tasto\n>> ");
                        Console.ReadLine();
                        break;
                    
                    case 4:
                        keepOnGoing = false;
                        break;
                    default:
                        Console.WriteLine("Indice menu non valido!");
                        break;
                }



            } while (keepOnGoing);

        }
    }
}
