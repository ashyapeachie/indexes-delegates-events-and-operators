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

    // public
    // public event
}