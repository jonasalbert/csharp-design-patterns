using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Decorator
{   
    public class Synchronizable: Decorator
    {

        public Synchronizable(PrimeItem primeItem)
            : base(primeItem)
        {

        }




        public void Sync()
        {
            Console.WriteLine("");
            Console.WriteLine("Sync Started...");
            foreach (ModelLocation location in CollectionLocation.Instance.List)
            {   
                foreach(PrimeItem item in _primeItem.List)
                {
                    if ((item.PrimeFormula % location.Prime) == 0)
                    {
                        item.PrimeFormula = this.ReComputePrimeFormula(location.Prime, item.PrimeFormula);
                        Console.WriteLine(String.Format("Sending {0} \t to \t{1}\t\t{2}", item.Name, location.Name, item.PrimeFormula));
                    }
                }
            }
        }

        public override void Display()
        {
            base.Display();
        }

        //https://www.geeksforgeeks.org/print-all-prime-factors-of-a-given-number/
        protected List<int> ListOfPrime(int primeFormula)
        {
            int n = primeFormula;
            List<int> listOfPrime = new List<int>();

            // Print the number of 2s that divide n 
            while (n % 2 == 0)
            {
                listOfPrime.Add(2);
                n /= 2;
            }

            // n must be odd at this point. So we can 
            // skip one element (Note i = i +2) 
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                // While i divides n, print i and divide n 
                while (n % i == 0)
                {
                    listOfPrime.Add(i);
                    n /= i;
                }
            }

            // This condition is to handle the case whien 
            // n is a prime number greater than 2 
            if (n > 2)
                listOfPrime.Add(n);

            return listOfPrime;
        }
        protected int ReComputePrimeFormula(int primeToRemove, int primeFormula)
        {
            List<int> listOfPrime = new List<int>(this.ListOfPrime(primeFormula));
            listOfPrime.Remove(primeToRemove);

            int newPrime = 1;
            foreach (int p in listOfPrime) newPrime = newPrime * p;

            return newPrime;
        }
    }
}
