using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Portfolio
{
    class Program
    {
        private List<Stock> list;

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();


        }
        public void Run()
        
        {

            list = new List<Stock>();
              

            bool running = true;
            string choice = "";

            do
            {
                ShowMenu();
                choice = GetUserChoice();
                switch (choice)
                {
                    case "1": AddStock(); break;
                    case "2": ShowStocks() ; break;
                    case "3": ; break;
                    case "9": running = false; break;
                    default: ShowMenuSelectionError(); break;
                }
            } while (running);
          }

        private void ShowStocks()
        {
            foreach (Stock print in list)
            {
                System.Console.WriteLine(print);
            }
        }

        private void ShowMenuSelectionError()
        {
            Console.WriteLine("Menu Selection Error");
        }

        public string GetUserChoice()
        {
        string choice = Console.ReadLine();
        return choice;
    }

        private void ShowMenu()
        {
            Console.WriteLine("1 - Add Stock");
            Console.WriteLine("2 - Show Stocks");
            Console.WriteLine("3 - ");
            Console.WriteLine("9 - Exits program");

        }

        public void AddStock()
        {
            Console.WriteLine("Add Name: ");
            String Name = Console.ReadLine();
            Console.WriteLine("Type Amount: ");
            Double A = Double.Parse(Console.ReadLine());
            Console.WriteLine("Type Price: ");
            int P = int.Parse(Console.ReadLine());
            Stock s = new Stock(Name, A, P);
            list.Add(s);



        }
    }
      }
    
    

