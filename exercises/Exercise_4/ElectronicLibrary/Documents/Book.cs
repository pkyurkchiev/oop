using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronicLibrary.Interface;
using ElectronicLibrary.Abstract;

namespace ElectronicLibrary.Documents
{
    public class Book : Document, ISendable
    {
        #region Fields
        public string author;
        public string title;
        public decimal price;
        #endregion

        #region Properties
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        #endregion

        #region Constructor
        public Book(int id, string nomer, DateTime createDate, string author, string title, decimal price)
            : base(id, nomer, createDate)
        {
            this.author = author;
            this.title = title;
            this.price = price;
        }
        #endregion

        #region Methods
        public void Send()
        {
            Console.WriteLine("Book is send.");
        }
        #endregion
    }
}
