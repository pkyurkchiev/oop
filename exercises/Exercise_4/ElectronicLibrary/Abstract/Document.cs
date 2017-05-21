using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicLibrary.Abstract
{
    public abstract class Document
    {
        #region Fields
        private int id;
        private string nomer;
        private DateTime createDate;
        protected string emailAddress;
        #endregion

        #region Properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Nomer
        {
            get { return nomer; }
            set { nomer = value; }
        }
        public DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }
        #endregion

        #region Constructor
        public Document(int id, string nomer, DateTime createDate)
        {
            this.id = id;
            this.nomer = nomer;
            this.createDate = createDate;
        }
        #endregion
    }
}
