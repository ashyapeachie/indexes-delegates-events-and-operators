/* 
Author: Aham
Filename: ProductList.cs
Description: class wraps a List<Product>; supports access via indexer (int or string),
    custom + and - operators to add / remove products, and a delegate + event system
    that fires when products are changed
 */

using System;
using System.Collections.Generic;

class ProductList {
    private List<Product> products = new();

    /* defining a simple delegate and event */
    public delegate void ListChangedHandler();
    public event ListChangedHandler Changes;

    public void Add(Product p) {
        products.Add(p);
        Changes?.Invoke();
    }

    public void Remove(Product p) {
        products.Remove(p);
        Changes?.Invoke();
    }

    /* operator overloads */
    public static ProductList operator +(ProductList list, Product p) {
        list.Add(p);
        return list;
    }
    
    public static ProductList operator -(ProductList list, Product p) {
        list.Remove(p);
        return list;
    }

    /* indexer */
    // public Product this[] {}

    // public override string ToString() {}
}
