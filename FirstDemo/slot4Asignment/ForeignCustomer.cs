using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.slot4Asignment
{
    public class ForeignCustomer :Customer
    {

        private string nationality;

        public ForeignCustomer(string customerCode, string fullName, DateTime invoiceDate, string nationality, int quantity, int unitPrice)
            : base(customerCode, fullName, invoiceDate, quantity, unitPrice)
        {
            this.nationality = nationality;
        }

        public override void CalculateTotalAmount()
        {
            totalAmount = quantity * unitPrice;
        }

        public override void PrintInvoice()
        {
            base.PrintInvoice();
            Console.WriteLine($"Nationality: {nationality}");
        }
    }
}
