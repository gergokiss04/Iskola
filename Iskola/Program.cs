using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//1.Feladat:Project elnevezése
namespace Iskola
{
    public class Program
    {
        static void Main(string[] args)
        {
            //2.Feladat:Fájl beolvasása és tárolása
            StreamReader sr = new StreamReader("nevek.txt");
            List<Students> listam = new List<Students>();
           
            while (!sr.EndOfStream)
            {
                Students s = new Students(sr.ReadLine());
                listam.Add(s);
                
            }
            
            sr.Close();

            //3.Feladat:Összes tanuló megjelenítése konzolon:
            Console.WriteLine($"3.Feladat: {listam.Count} db tanuló jár az iskolába!");

            //4.Feladat:Első és utolsó azonosító megjelenítése konzolon:
            int counter = 0;
            foreach (var item in listam)
            {
                
                if (counter==0)
                {
                    Console.WriteLine(item.azonosito());
                    counter++;
                }
                else if (counter>0)
                {
                    counter++;
                    
                    if (listam.Count==counter)
                    {
                        Console.WriteLine(item.azonosito());
                    }
                }
                
            }

            //6.Feladat:Adatok kiíratása új txt fájlba!

            StreamWriter sw = new StreamWriter("azonositok.txt", false, encoding: Encoding.UTF8);
            foreach (var item in listam)
            {
                sw.WriteLine(item.studentname + " " + item.azonosito());
            }
            sw.Close();


            Console.ReadLine();
        }

    }
}
