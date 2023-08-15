using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.slot4Asignment
{
    public class VietnameseCustomer : Customer
    {
        private string customerType;

        public VietnameseCustomer(string customerCode, string fullName, DateTime invoiceDate, string customerType, int quantity, int unitPrice)
            : base(customerCode, fullName, invoiceDate, quantity, unitPrice)
        {
            this.customerType = customerType;
        }

        public override void CalculateTotalAmount()
        {
            int threshold = 0;
            if (quantity <= 50)
                threshold = 50;
            else if (quantity <= 100)
                threshold = 100;
            else if (quantity <= 200)
                threshold = 200;
            else
                threshold = 201;

            if (quantity <= threshold)
                totalAmount = quantity * unitPrice;
            else
                totalAmount = threshold * unitPrice + (quantity - threshold) * (unitPrice * 2);
        }

        public override void PrintInvoice()
        {
            base.PrintInvoice();
            Console.WriteLine($"Customer Type: {customerType}");
        }
    }
}
