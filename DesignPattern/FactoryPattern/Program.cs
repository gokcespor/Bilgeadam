using FactoryPattern.Creator;
using FactoryPattern.Interface;

ProductCreator productCreator = new ProductCreator();
IProduct product;

for (int i = 0; i < 13; i++)
{
    product = productCreator.FactoryMethod(i);
    Console.WriteLine($"Coffee Beans: {product.ShipFrom()}");
}