using System;
namespace Class_Inheritance.Models
{
    public class Book:Product
    {
        public string authorName;
        public int pageCount;
        public int discountPercent;

        public void GetInfo()
        {
            Console.WriteLine($"\n Author: {authorName}\n Pages: {pageCount}\n Discount Percent: {discountPercent}%\n Book Name: {productName}\n CP: {costPrice}\n Price: {salePrice}");
        }

        public void GetDiscountedPrice()
        {
            Console.WriteLine($"*********************\n  Sale Price: { salePrice - (salePrice * discountPercent / 100)}\n*********************");
        }
    }
}
