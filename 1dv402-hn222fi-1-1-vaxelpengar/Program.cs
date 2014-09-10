using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402_hn222fi_1_1_vaxelpengar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Deklarerar lokala variabler
            double totalCost = 0;
            uint receivedAmount = 0;
            uint[] listNumberEachDenomination;
            uint totalChange = 0;
            uint[] denominations = {500,100,50,20,10,5,1};
            uint roundedCost = 0;

            do
            {
            // Anropar metod för att läsa in totalsumman och erhållet belopp
            totalCost = ReadPositiveDouble(Resource1.Cost_Prompt);
            receivedAmount = ReadUint(Resource1.Cash_Prompt, (uint)totalCost);
 
            // Beräkna belopp att betala, öresavrundningen och växel tillbaka
            roundedCost = (uint)Math.Round(totalCost);
            totalChange = receivedAmount-roundedCost;

            // Anropar metod för att 
            listNumberEachDenomination = SplitIntoDenominations(totalChange, denominations);

            // Visar kvittot i consolfönstret
            ViewReceipt(totalCost, roundedCost-totalCost, roundedCost, receivedAmount, totalChange, listNumberEachDenomination, denominations);

            // Avslutar programmet om användaren trycker på Esc annars kör igen
            Console.WriteLine("\n");
            ViewMessage(Resource1.EndQuestion_Prompt);
            Console.WriteLine("\n");
            }                   
            while(Console.ReadKey().Key != ConsoleKey.Escape);


        }

        /// <summary>
        /// Läser in ett positivt flyttal från användaren
        /// </summary>
        /// <param name="prompt">Frågan i text i form av string till användaren</param>
        /// <returns>Positivt flyttal</returns>
        private static double ReadPositiveDouble(String prompt)
        {
            //Deklarerar lokal variabel
            double readValue = 0;

            // Läser in och returnerar en double
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    readValue = double.Parse(Console.ReadLine());
                    // -Verkar fel i decimalfrågan
                    if (readValue<1 || ((readValue*100)%1 !=0))
                    {
                        throw new ApplicationException();
                    }
                    return readValue;
                }
                catch
                {
                    ViewMessage("\n" + String.Format(Resource1.WrongDouble_Prompt,readValue)+ "\n", false);
                }
            }
            
        }

        /// <summary>
        /// Läser in ett positivt heltal från användaren
        /// </summary>
        /// <param name="prompt">Frågan i text i form av string till användaren</param>
        /// <param name="minValue">Minsta värde som kan anges</param>
        /// <returns>Positivt flyttal</returns>
        private static uint ReadUint(String prompt, uint minValue)
        {
            // Deklarerar lokal variabel
            uint readValue = 0;

            // Läser in och returnerar en uint
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    readValue = uint.Parse(Console.ReadLine());
                    if (readValue < minValue)
                    {
                        throw new ApplicationException();
                    }
                    return readValue;
                }
                catch
                {
                    ViewMessage("\n" + String.Format(Resource1.WrongInt_Prompt,readValue, minValue)+ "\n", true);
                }
            }


        }

        /// <summary>
        /// Delar upp växeln
        /// </summary>
        /// <param name="change">Summan som ska delas upp</param>
        /// <param name="denominations">Vilka olika valörer som finns i form av en array</param>
        /// <returns>En frekvenstabell i form av en array för varje valör</returns>
        private static uint[] SplitIntoDenominations(uint change, uint[] denominations)
        {
            // Deklarerar lokala variabler och anger längden
            uint[] listNumberEachDenomination;
            listNumberEachDenomination = new uint[denominations.Length];

            // Går igenom varje valör uppifrån och ner och placerar antalet i en nya array 
            for (int i = 0; i < denominations.Length; i++)
            {
                listNumberEachDenomination[i] = change / denominations[i];
                change = change % denominations[i];
            }
                       
            return listNumberEachDenomination;
        }

        private static void ViewMessage(string message, bool isError = false)
        {
            if (isError==true)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(message);
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(message);
                Console.ResetColor();
            }
        }

        /// <summary>
        /// Skriver ut ett kvitto i consolfönstret
        /// </summary>
        /// <param name="subTotal">Totalsumman</param>
        /// <param name="roundingOffAmount">Öresvarundning</param>
        /// <param name="total">Totalkostnad efter öresavrundning</param>
        /// <param name="cash">Erhållen summa pengar</param>
        /// <param name="change">Växel tillbaka</param>
        /// <param name="notes">En array av typen int som säger hur många sedlar/mynt av varje sort</param>
        /// <param name="denominations">En array av typen int som säger vilka typer av sedlar som finns</param>
        private static void ViewReceipt(Double subTotal,double roundingOffAmount, uint total, uint cash, uint change, uint[] notes, uint[] denominations)
        {
            // Skriver ut kvittot
            Console.WriteLine("\n"+Resource1.Receipt_Prompt);
            Console.WriteLine("-------------------------------");
            Console.WriteLine(Resource1.Total_Prompt, subTotal);
            Console.WriteLine(Resource1.RoundingOffAmount_Prompt, roundingOffAmount);
            Console.WriteLine(Resource1.TotalCost_Prompt, total);
            Console.WriteLine(Resource1.ReceivedAmount_Prompt, cash);
            Console.WriteLine(Resource1.Change_Prompt, change);
            Console.WriteLine("-------------------------------\n");
            
            // Skriver ut antalet sedlar av varje typ
            for (int i=0;i<denominations.Length;i++)
            {
                if (notes[i]!=0)
                {
                    Console.WriteLine(Resource1.Denominations_Prompt, denominations[i], notes[i]);
                }
            }
            
        }
    }
}
