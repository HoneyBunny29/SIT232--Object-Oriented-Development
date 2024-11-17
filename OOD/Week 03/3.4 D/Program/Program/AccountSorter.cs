using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BucketSort
{
    internal class AccountSorter
    {
        public static class AccountsSorter
        {
            // Sorting technique for arrays
            public static void Sort(Account[] accounts, int b)
        {
            // Using the Bucket Sort algorithm in implementation
                List<List<Account>> buckets = new List<List<Account>>(b);
            decimal M = CalculateMaxValue(accounts);

            // Initialize buckets
                for (int i = 0; i < b; i++)
            {
                buckets.Add(new List<Account>());
            }

            // Place components within buckets
                foreach (var acc in accounts)
            {
                int bucketIndex = (int)Math.Floor(b * acc.Balance / M);

                // Verify that the bucketindex is inside the allowed range.
                    if (bucketIndex >= b)
                {
                    bucketIndex = b - 1;
                }

                buckets[bucketIndex].Add(acc);
            }

            // Arrange every bucket
            foreach (var bucket in buckets)
            {
                nextSort(bucket);
            }

            // Join buckets together
                List<Account> result = new List<Account>();
            foreach (var bucket in buckets)
            {
                result.AddRange(bucket);
            }

            // Replicate the sorted elements to the original array.
                for (int i = 0; i < result.Count; i++)
            {
                    accounts[i] = result[i];
            }
        }

        //Sorting technique for List<Account>
        public static void Sort(List<Account> accounts, int b)
        {
            // Using the Bucket Sort algorithm in implementation
                List<List<Account>> buckets = new List<List<Account>>(b);
            decimal M = CalculateMaxValue(accounts);

            // Set up the buckets
                for (int i = 0; i < b; i++)
            {
                buckets.Add(new List<Account>());
            }

            // Place components inside buckets
                foreach (var acc in accounts)
            {
                int bucketIndex = (int)Math.Floor(b * acc.Balance / M);

                // Verify that the bucketindex is inside the allowed range.
                    if (bucketIndex >= b)
                {
                    bucketIndex = b - 1;
                }

                buckets[bucketIndex].Add(acc);
            }

            // Arrange every bucket
            foreach (var bucket in buckets)
            {
                nextSort(bucket);
            }

            // Join buckets together
                accounts.Clear();
            foreach (var bucket in buckets)
            {
                accounts.AddRange(bucket);
            }
        }

        // NextSort assistance method (native.NET sorting methods can be used here)
            private static void nextSort(List<Account> bucket)
        {
                // NextSort implementation
                // Array is an option.List<T> or Sort<T>.Sort this out.
                bucket.Sort((a1, a2) => a1.Balance.CompareTo(a2.Balance));
        }

        // A helper function to determine the highest value of the key
            private static decimal CalculateMaxValue(Account[] array)
        {
            decimal max = decimal.MinValue;
            foreach (var acc in array)
            {
                if (acc.Balance > max)
                {
                    max = acc.Balance;
                }
            }
            return max;
        }

        // A helper function to determine List<Account>'s maximum key value
            private static decimal CalculateMaxValue(List<Account> array)
        {
            decimal max = decimal.MinValue;
            foreach (var acc in array)
            {
                if (acc.Balance > max)
                {
                    max = acc.Balance;
                }
            }
            return max;
        }


    }
}
}
