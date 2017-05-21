using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronicLibrary.Interface;
using ElectronicLibrary.Abstract;

namespace ElectronicLibrary.Documents
{
    public class Invoice : Document, IPrintable, ISendable, IEmailable
    {
        #region Fields
        private string company;
        private string client;
        private decimal price;
        private int quantity;
        private decimal totalPrice;
        #endregion

        #region Properties
        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        public string Client
        {
            get { return client; }
            set { client = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public decimal TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
        #endregion

        #region Constructor
        public Invoice(int id, string nomer, DateTime createDate, string company, string client, decimal price, int quantity, decimal totalPrice, string emailAddress)
            : base(id, nomer, createDate)
        {
            this.company = company;
            this.client = client;
            this.price = price;
            this.quantity = quantity;
            this.totalPrice = totalPrice;
            base.emailAddress = emailAddress;
        }
        #endregion

        #region Methods
        public void Print()
        {
            Console.WriteLine("Invoice is print.");
        }
        public void Send()
        {
            Console.WriteLine("Invoice is send.");
        }
        public void Email()
        {
            Console.WriteLine("Invoice is send to email " + emailAddress);
        }
        #endregion
    }
}
