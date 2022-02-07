using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Oppgave_3_4
{
    internal class Program
    {
        
        static Random Random = new Random();
        static void Main(string[] args)
        {
            char[] alphabet =    "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            /*har[] cypherArray = "LEJKTGUDMFRSOAPQIZBVWXYCHN".ToCharArray();*/
            char[] randomArray = ShuffleArray("ABCDEFGHIJKLMNOPQRSTUVWXYZ");



            Console.Write("Skriv inn ønsket ord");
            Console.WriteLine();
            string input = Console.ReadLine().ToUpper();
            char[] cypherOrd = new char[input.Length];
            Console.WriteLine();
                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < alphabet.Length; j++)
                    {
                        if (input[i] == alphabet[j])
                        {
                        string letter = randomArray[j].ToString();
                        
                        cypherOrd[i] = randomArray[j];
                        Console.Write(randomArray[j]);
                        }
                    }
                }
               
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Dekryptert: ");
                Console.WriteLine();

                foreach (var t in cypherOrd)
                {
                    for (int j = 0; j < randomArray.Length; j++)
                    {
                        if (t == randomArray[j])
                        {
                            Console.Write(alphabet[j]);
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("shuffled Array: " + randomArray.Length);

                foreach (var letters in randomArray)
                {
                    Console.Write(letters);
                }


            Console.ReadLine();
        }

        public static char[] ShuffleArray(string str)
        {
            char[] array = str.ToCharArray();
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }

            return array;
        }
    }
}
