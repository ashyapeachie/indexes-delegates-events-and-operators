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

        var p1 = new Product();
        var p2 = new Product();
        var p3 = new Product();
        // creating products

        // add & remove elements using operator overloads

        Console.WriteLine("First product:");
        Console.WriteLine(list[0]);
        // access via indexer
    }
}
