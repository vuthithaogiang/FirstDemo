using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.slot4Asignment
{
    public abstract class Customer
    {
        protected string customerCode;
        protected string fullName;
        protected DateTime invoiceDate;
        protected int quantity;
        protected int unitPrice;
        protected double totalAmount;

        public Customer(string customerCode, string fullName, DateTime invoiceDate, int quantity, int unitPrice)
        {
            this.customerCode = customerCode;
            this.fullName = fullName;
            this.invoiceDate = invoiceDate;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }

        public abstract void CalculateTotalAmount();

        public virtual void PrintInvoice()
        {
            Console.WriteLine($"Customer Code: {customerCode}");
            Console.WriteLine($"Full Name: {fullName}");
            Console.WriteLine($"Invoice Date: {invoiceDate.ToShortDateString()}");
            Console.WriteLine($"Total Amount: {totalAmount}");
        }
    }
}
