using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Textdateien
{
    class Program
    {
        private static string readInput(string questionPath)
        {
            Console.Write(questionPath);
            string input = Console.ReadLine();
            return input;
        }

        private static string readSearch(string questionSearch)
        {
            Console.Write(questionSearch);
            string input = Convert.ToString(Console.Read());
            return input;
        }
        static void Main(string[] args)
        {
            /*
            string fileName;            //AUFGABE1

            fileName = readInput("Dateipfad eingeben: ");
            StreamReader fromFile = new StreamReader(fileName);
            string line;

            while ((line = fromFile.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            int count = 0;
            char search;
            search = readSearch("\n\nNach welchem char suchen: ");

            using (fromFile = new StreamReader(fileName))
            {
                while ((line = fromFile.ReadLine()) != null)
                {
                    foreach (char letter in line)
                    {
                        if (search == letter)
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine("\n\n{0} wurde {1}. mal gefunden.", search, count);
            Console.ReadLine();
            fromFile.Close();
            Console.ReadLine();*/





            /*                          //AUFGABE2
            string file1, file2;

            file1 = readInput("Dateipfad 1 eingeben: ");
            file2 = readInput("Dateipfad 2 eingeben: ");

            StreamReader fromFile1 = new StreamReader(file1);
            StreamReader fromFile2 = new StreamReader(file2);
            */


            //Variablendeklaration
            string file, line;
            int count, cardID, std, nr;
            char[] trenn = { ' ', '\t' };
            string[] teile = new string[3];
            count = 0;
            std = 0;
            //Welche Datei
            file = readInput("Bitte Dateipfad eingeben: ");
            StreamReader fromFile = new StreamReader(file);
            //Datei ausgeben
            while ((line = fromFile.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            //Card-ID eingeben
            Console.Write("\nBitte zu berechnende Card-ID eingeben: ");
            cardID = Convert.ToInt32(Console.ReadLine());

            //Berechnung
            using (fromFile = new StreamReader(file))
            {
                while ((line = fromFile.ReadLine()) != null)
                {
                    teile = line.Split(trenn, StringSplitOptions.RemoveEmptyEntries);
                    std = Int32.Parse(teile[2]);
                    nr = Int32.Parse(teile[0]);
                    if (cardID == nr)
                    {
                        count = count + (std/60);
                        if (count >= 500)
                        {
                            break;
                        }
                    }
                }
            }
            //Ausgabe Limit
            if (count >= 500)
            {
                Console.Write("Die Kartennummer {0}. ist mit {1}h über dem limit\nStand: {2}", cardID, count, teile[1]);
            }
            else
            {
                Console.Write("Die Kartennummer {0}. ist mit {1}h innerhalb", cardID, count);
            }
            Console.ReadKey();
        }   
    }   
}

