using Assignment4.Entities;
using Assignment4.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.SortingAlgorithms
{
    class BucketSort
    {
        public static List<Shirt> SizeAscending(params Shirt[] x)
        {
            List<Shirt> sortedArray = new List<Shirt>();

            int numOfBuckets = Enum.GetValues(typeof(Size)).Length;

            List<Shirt>[] buckets = new List<Shirt>[numOfBuckets];

            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<Shirt>();
            }

            for (int i = 0; i < x.Length; i++)
            {
                int bucket = (int)x[i].Size;
                buckets[bucket].Add(x[i]);
            }

            for (int i = 0; i < numOfBuckets; i++)
            {
                sortedArray.AddRange(buckets[i]);
            }
            return sortedArray;
        }

        public static List<Shirt> SizeDescending(params Shirt[] x)
        {
            List<Shirt> sortedArray = new List<Shirt>();

            int numOfBuckets = Enum.GetValues(typeof(Size)).Length;

            List<Shirt>[] buckets = new List<Shirt>[numOfBuckets];

            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<Shirt>();
            }

            for (int i = 0; i < x.Length; i++)
            {
                int bucket = (int)x[i].Size;
                buckets[(numOfBuckets - 1) - bucket].Add(x[i]);
            }

            for (int i = 0; i < numOfBuckets; i++)
            {
                sortedArray.AddRange(buckets[i]);
            }
            return sortedArray;
        }
    }
}