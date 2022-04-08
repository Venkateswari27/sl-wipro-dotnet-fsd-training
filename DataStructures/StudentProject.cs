using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
	public class StudentProject
	{
        public static string[] ReadCities()
        {
            string citiesFileName = "C:\\Users\\Hemanth Nandyala\\Desktop\\cities.txt";
			return System.IO.File.ReadAllLines(citiesFileName);
		}
		public static void DisplayCities(string[] cities)
		{
			foreach (string city in cities)
			{
				Console.Write(city + " ");
			}
			Console.WriteLine();
		}

		public static void SortCities(string[] cities)
        {
            for (int i = 0; i < cities.Length - 1; i++)
            {
                for (int j = i + 1; j < cities.Length; j++)
                {
                    if (string.Compare(cities[i], cities[j]) > 0)
                        Swap(cities, i, j);
                }
                //selection sort algorithm
            }
        }
        public static int FindCity(string[] cities, string city)
        {
            //binary search
            SortCities(cities);

            int minNum = 0;
            int maxNum = cities.Length - 1;

            int foundElem = -1;

            while (minNum <= maxNum && foundElem == -1)
            {
                int mid = (minNum + maxNum) / 2;

                if (city.Equals(cities[mid], StringComparison.OrdinalIgnoreCase))
                {
                    foundElem = ++mid;
                    break;
                }
                else if (city.CompareTo(cities[mid]) < 0)
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }

            return foundElem;
        }
        static void Swap(string[] cities, int i, int j)
        {
            string temp = cities[i];
            cities[i] = cities[j];
            cities[j] = temp;
        }
    }
}
