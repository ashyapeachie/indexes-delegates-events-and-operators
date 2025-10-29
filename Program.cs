/* 
Author: Aham
Filename: Programs.cs
Description: 
 */

using System;

class Program {
    static void Main() {
        var list = new ProductList();

        list.Changes += () => Console.WriteLine("Product list has chaged!");
        // event using a lambda

        var p1 = new Product("A100", "Laptop", 999.99m);
        var p2 = new Product("B200", "Monitor", 199.99m);
        var p3 = new Product("C300", "Mouse", 29.99m);
        // creating products

        list += p1;
        list += p2;
        list += p3;
        list -= p2;
        // add & remove elements using operator overloads
        Console.WriteLine("\nCurrent list:");
        Console.WriteLine(list);

        Console.WriteLine("First product:");
        Console.WriteLine(list[0]);
        // access via indexer
    }
}

