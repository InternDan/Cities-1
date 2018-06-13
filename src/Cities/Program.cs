﻿using System;
using System.Collections.Generic;
using Cities.Comparers;

namespace Cities
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<City> cities = CityDataImporter.LoadData();

            // TODO Swap out comparers as desired
            //IComparer<City> comparer = new PopulationComparer();
            MultiComparer multcomp = new MultiComparer();
            multcomp.Comparers.Add(new StateComparer());
            multcomp.Comparers.Add(new AreaComparer());

            cities.Sort(multcomp);

            PrintCities(cities);

            Console.ReadLine();
        }

        private static void PrintCities(List<City> cities)
        {
            Console.WriteLine(City.GetTableHeader());

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

        }
    }
}
