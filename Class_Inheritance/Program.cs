using System;
using Class_Inheritance.Models;

namespace Class_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            book.authorName = "George Orwell";
            book.pageCount = 64;
            book.discountPercent = 5;
            book.productName = "Animal Farm";
            book.costPrice = 2.00;
            book.salePrice = 3.60;

            book.GetInfo();
            book.GetDiscountedPrice();

            _ = new Book();

            book.authorName = "Will Smith";
            book.pageCount = 432;
            book.discountPercent = 15;
            book.productName = "Will Smith's";
            book.costPrice = 18;
            book.salePrice = 39.10;

            book.GetInfo();
            book.GetDiscountedPrice();

            _ = new Book();
            
            book.authorName = "Rowling";
            book.pageCount = 68;
            book.discountPercent = 50;
            book.productName = "Harry Poter";
            book.costPrice = 10;
            book.salePrice = 40;

            book.GetInfo();
            book.GetDiscountedPrice();

        }
    }
}
