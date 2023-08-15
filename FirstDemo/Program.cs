// See https://aka.ms/new-console-template for more information
using System;
using FirstDemo.demo1;
using FirstDemo.slot5Asignment;
using FirstDemo.slot4Asignment;

public class Program
{
    //slot 5
    public static void Main(string[] args)
    {
        PhoneBook phoneBook = new PhoneBook();

        phoneBook.InsertPhone("John", "123456789");
        phoneBook.InsertPhone("Jane", "987654321");
        phoneBook.InsertPhone("John", "111111111");
        phoneBook.InsertPhone("Doe", "555555555");

        phoneBook.Sort();

        phoneBook.SearchPhone("John");

        phoneBook.UpdatePhone("Doe", "666666666");

        phoneBook.SearchPhone("Doe");

        phoneBook.RemovePhone("Jane");

        Console.ReadLine();
    }
    public static void Main1(string[] args)
    {
        Teacher t = new Teacher();
        t.Tels.Add("1231232");
        t.Tels.Add("223255");
        Console.WriteLine(t.Tels[0]);

    }

    //slot 4
    public static void Main2(string[] args)
    {
        List<Customer> customerList = new List<Customer>();

        customerList.Add(new VietnameseCustomer("VN001", "Nguyen Van A", new DateTime(2023, 8, 10), "residential", 80, 1200));
        customerList.Add(new ForeignCustomer("NN001", "John Smith", new DateTime(2023, 8, 11), "USA", 150, 2000));

        foreach (var customer in customerList)
        {
            customer.CalculateTotalAmount();
            customer.PrintInvoice();
            Console.WriteLine("---------------------");
        }

        Console.ReadLine();

    }
}