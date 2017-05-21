using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronicLibrary.Interface;
using ElectronicLibrary.Abstract;

namespace ElectronicLibrary.Documents
{
    public class Contract : Document, IPrintable, IEmailable
    {
        #region Fields
        public string employee;
        public string employer;
        public DateTime startDate;
        #endregion

        #region Properties
        public string Employee
        {
            get { return employee; }
            set { employee = value; }
        }
        public string Employer
        {
            get { return employer; }
            set { employer = value; }
        }
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        #endregion

        #region Constructor
        public Contract(int id, string nomer, DateTime createDate, string employee, string employer, DateTime startDate, string emailAddress)
            : base(id, nomer, createDate)
        {
            this.employee = employee;
            this.employer = employer;
            this.startDate = startDate;
            base.emailAddress = emailAddress;
        }
        #endregion

        #region Methods
        public void Print()
        {
            Console.WriteLine("Contract is print");
        }
        public void Email()
        {
            Console.WriteLine("Contract is send to email " + emailAddress);
        }
        #endregion
    }
}
