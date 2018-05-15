using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
        }
        public static List<Snack> ReadSnackFile(string filename)
        {
            List<Snack> snack = new List<Snack>();

            StreamReader sr = null;
            try
            {
                sr = new StreamReader(filename);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();


                    string[] tokens = line.Split('\t');

                    string name = tokens[0];
                    double price = double.Parse(tokens[1]);
                    string category = tokens[2];
                    string descrip = tokens[3];
                    string taste = tokens[4];

                    Snack p = new Snack(name, price, category, descrip, taste);
                    snack.Add(p);

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error reading file");
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
            return snack;
        }

        public static List<Drink> ReadDrinkFile(string filename)
        {
            List<Drink> drink = new List<Drink>();

            StreamReader sr = null;

            try
            {
                sr = new StreamReader(filename);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    string[] tokens = line.Split('\t');

                    string name = tokens[0];
                    double price = double.Parse(tokens[1]);
                    string category = tokens[2];
                    string descrip = tokens[3];
                    string temp = tokens[4];
                    int size = int.Parse(tokens[5]);

                    Drink d = new Drink(name, price, category, descrip, temp, size);
                    drink.Add(d);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error reading file");
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }

            return drink;
        }

        public static void List(List<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static string DisplayMessage()
        {
            return "Function Message";
        }
        
        
    }
    
}
