using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificação
{
    class Program
    {
        static List<int> myList = new List<int>();

        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    int y = 1000000000;
                    short x = (short)y;

                    Console.WriteLine(x);
                
                }
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("deu ruim");
                
            }
            catch(Exception e)
            {
                Console.WriteLine("heuehue");
            }
            catch
            {
                Console.WriteLine("heuehue");
            }
            finally
            {
                Console.WriteLine("salsifufu");
            }

            decimal temperature = 732.92M;
            decimal exact = 10;
            DateTime date = DateTime.Now;

            Console.WriteLine(string.Format("temp: {0:N1}", temperature));
            Console.WriteLine(string.Format("exact: {0:N2}", exact));
            Console.WriteLine(string.Format("0:t = {0:t}", date));
            Console.WriteLine(string.Format("0:d = {0:d}", date));
            Console.WriteLine(string.Format("0:hh:mm = {0:hh:mm}", date));
            Console.WriteLine(string.Format("0:dd/mm/yy = {0:dd/MM/yy}", date));

            Debug.Assert(1 != 1, "teste");

            foreach (var a in testFunction())
                Console.WriteLine("a");
            
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            

            foreach (int i in RunningTotal())
            {
                Console.WriteLine(i);
            }

            var b = testFunction();
            

            Console.ReadKey();
        }

        static IEnumerable<int> RunningTotal()
        {
            int runningTotal = 0;
            foreach (int i in myList)
            {
                runningTotal += i;
                yield return runningTotal;
            }
        }

        //int? e Nullable<int>

        static IEnumerable<int> testFunction()
        {
            var a = Math.Sqrt(153);

            if (a > 0)
            {
                yield break;
            }
            else
            {
                var b = DateTime.Now;

                a += b.Ticks;
            }

            yield return 2;
        }
        
        class Teste
        {
            public Teste()
            {

            }

            public static void Save<T>(T target) where T : Teste, new()
            {

            }
        }
    }
}
