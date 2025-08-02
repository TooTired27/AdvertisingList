using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TestClassifiedAd
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            ClassifiedAd[] adList = new ClassifiedAd[5];
            int nrEl = 0;

            for (int x=nrEl; x< adList.Length; x++)
            {

                AddClassifiedAd(adList, ref nrEl);

            }
            WriteLine();
            WriteLine("List of advertisements:");
            for(int x = 0; x < nrEl; x++)
            {
                adList[x].DisplayAd();
            }

            ReadLine();
        }
        static void AddClassifiedAd(ClassifiedAd[]adList,ref int nrEl)
        {
            Write("Enter the category for the advertisement: ");
            string cat = ReadLine();
            Write("Enter the number of words in the advertisement: ");
            int words = int.Parse(ReadLine());
            Write("Does this customer have a different rate: (Y/N) ");
            char response= char.Parse(ReadLine().ToUpper());
            if (response == 'Y')
            {
                Write("Enter the rate for this customer: ");
                double rate=double.Parse(ReadLine());
                adList[nrEl] = new ClassifiedAd(cat, words, rate);
                nrEl++;
            }
            else
            {
                adList[nrEl] = new ClassifiedAd(cat, words);
                nrEl++;
            }
            WriteLine();
        }
    }
}
