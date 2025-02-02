﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> priceByProduct = new Dictionary<string, decimal>();
            Dictionary<string, int> quantityByProduct = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "buy")
                {
                    break;
                }

                string[] parts = line.Split();
                string product = parts[0];
                decimal price = decimal.Parse(parts[1]);
                int quantity = int.Parse(parts[2]);
                if (priceByProduct.ContainsKey(product))
                {
                    priceByProduct[product] = price;
                    quantityByProduct[product] += quantity;

                }
                else
                {
                    priceByProduct.Add(product, price);
                    quantityByProduct.Add(product, quantity);
                }
            }

            foreach (var kvp in priceByProduct)
            {
                string product = kvp.Key;
                decimal price = kvp.Value;
                int quantity = quantityByProduct[product];

                decimal totalPrice = quantity * price;

                Console.WriteLine($"{product} -> {totalPrice:F2}");
            }

            //var sorted = priceByProduct
            //    .OrderByDescending(kvp => kvp.Value * quantityByProduct[kvp.Key])
            //    .ToDictionary(x => x.Key, x => x.Value * quantityByProduct[x.Key]);

            //foreach (var kvp in sorted)
            //{
            //    Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            //}
        }
    }
}
