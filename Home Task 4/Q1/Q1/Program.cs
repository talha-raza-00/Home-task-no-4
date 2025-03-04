using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static string[,] inventory =
        {
            {"001","Apple","55.5","10" },
            {"002","beaf","11","92"},
            {"003","cake","1.5","62"},
            {"004","Dates","5.5","15"},
            {"005","chips","6.5","1"},

        };

        static void display()
        {
            Console.WriteLine("Product ID \t Product Name \t Price \t Quantity ");
            for (int i = 0; i < inventory.GetLength(0); i++)
            {
                Console.WriteLine("{0} \t\t {1} \t\t {2} \t {3}", inventory[i,0], inventory[i, 1], inventory[i, 2], inventory[i, 3]);
            }
        }

        static void hpproduct()
        {
            double maxprice = 0.0;
            int index = 0;
            for (int i = 0; i < inventory.GetLength(0); i++)
            {
                double price = double.Parse(inventory[i, 2]);
                if (price > maxprice)
                {
                    maxprice = price;
                    index = i;
                }

            }
            Console.WriteLine("The highest value product is : {0} | {1} | {2} | {3}  ", inventory[index,0], inventory[index, 1], inventory[index, 2], inventory[index, 3]);



        }

        static void mpproduct()
        {
            double minprice = 9999999.00;
            int index = 0;
            for (int i = 0; i < inventory.GetLength(0); i++)
            {
                double price = double.Parse(inventory[i, 2]);
                if (price < minprice)
                {
                    minprice = price;
                    index = i;
                }

            }
            Console.WriteLine("The lowest value product is : {0} | {1} | {2} | {3}  ", inventory[index, 0], inventory[index, 1], inventory[index, 2], inventory[index, 3]);
        }

        static void lowstock()
        {
            int stablequantity = 25;
            //int index = 0;
            for(int i = 0;i < inventory.GetLength(0); i++)
            {
                int quant=int.Parse(inventory[i, 3]);
                if (quant < stablequantity)
                {
                    Console.WriteLine("the product with low Quantity is : ");
                    Console.WriteLine("{0} | {1} | {2} | {3} ", inventory[i, 0], inventory[i, 1], inventory[i, 2], inventory[i, 3]);

                }
            }
            
        }

        static void Update(string id,int quantiity)
        {
            for (int i = 0; i<inventory.GetLength(0); i++)
            {
                if(inventory[i, 0] == id)
                {
                    inventory[i, 3] = quantiity.ToString();
                    Console.WriteLine("update sucessfully!!");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid IN number!!");
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\t| Inventory managment store | \n");
                Console.WriteLine("1. Display Inventory");
                Console.WriteLine("2. Find Product with Highest Price");
                Console.WriteLine("3. Find Product with Lowest Price");
                Console.WriteLine("4. Find Low Stock Products");
                Console.WriteLine("5. Update Product Quantity");
                Console.WriteLine("6. Exit");

                Console.Write("\nEnter your choice : ");
                int cho=int.Parse(Console.ReadLine());

                switch (cho)
                {
                    case 1:
                        display();
                        break;
                    case 2:
                        hpproduct();
                        break;
                    case 3:
                        mpproduct();
                        break;
                    case 4:
                        lowstock();
                        break;
                    case 5:
                        Console.WriteLine("Enter product ID : ");
                        string id=Console.ReadLine();
                        Console.WriteLine("Enter new quantity : ");
                        int q=int.Parse(Console.ReadLine());
                        Update( id, q);
                        break;
                    case 6:
                        return;
                        

                    default:
                        Console.WriteLine("Inval9id chice !!");
                        break;

                }

            }

        }
    }
}
