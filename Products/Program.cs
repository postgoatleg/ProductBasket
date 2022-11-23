using System;
using ExceptionHandling;
using ProductsClass;

Product P1 = new("potato", 10);
Product P2 = new("maslo", 25);
Product P4 = new("maslo", 35);
Product P3 = new("toasts", 100);

Product p3 = P3 + P2;

try
{
    Product mr = p3 * -3;
}
catch(ProductMulpNegative) { }
Console.WriteLine(p3.GetPrice());
Console.WriteLine("Hello, World!");
Console.ReadKey();

