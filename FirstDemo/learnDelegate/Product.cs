using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.learnDelegate
{
    public delegate void UpdateQtyHandle(int n);
    public class Product
    {
        private int qty;

        public event UpdateQtyHandle QtyChanged;

        public Product()
        {
            QtyChanged += NotifyChangeQty;
            QtyChanged += SendEmailToAdmin;
            QtyChanged += SendSMSToStoreManager;

        }

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        public void NotifyChangeQty(int n)        
        {
            Console.WriteLine("Quantity of product was changed: " + n);
        }

        public void SendEmailToAdmin(int n)
        {
            // send email
        }

        public void  SendSMSToStoreManager(int n)
        {
            //sed SMS
        }

        public void IncreamentQty(int q)
        {
            if( q > 0 )
            {
                qty += q;
                QtyChanged(q);
                SendEmailToAdmin(q);
                SendSMSToStoreManager(q);
            }
        }
    }
}
