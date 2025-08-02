using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TestClassifiedAd
{
   
    internal class ClassifiedAd
    {
        string Catergory;
        int numWords = 0;
        double price = 0;
        readonly double rate = 0.09;
        public ClassifiedAd(string Category,int nWords)
        {
            this.Catergory = Category;
            this.numWords = nWords;
           price=rate*numWords;
        }
       public ClassifiedAd(string Category,int nWords,double newRate)
        {
            this.Catergory=Category;
            this.numWords = nWords;
            rate = newRate;
            price=nWords*newRate;
        }
        public void SetCategory(string Category)
        {
            this.Catergory = Category;
        }
        public string GetCategory()
        {
            return this.Catergory;
        }
        public void SetWords(int nWords)
        {
            this.numWords = nWords;
            price= nWords*0.09;

        }
        public int GetWords()
        {
            
            return this.numWords;
        }

        public double GetPrice(double price)
        {
          return price;
        }
        public void DisplayAd()
        {
            WriteLine("Category: {0}, Number of words: {1}, Price: {2}.",Catergory,numWords,price);
        }
    }
}
