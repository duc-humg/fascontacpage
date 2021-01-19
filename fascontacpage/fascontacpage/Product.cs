using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace fascontacpage
{
    [Table("Product")]
    public class Product
    {
        private string _firstname;
        [PrimaryKey]
        public string firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
                this._firstname = value;
            }
        }
        private string _lastname;
        [NotNull]
        public string lastname
        {
            get
            {
                return _lastname;
            }
            set
            {
                this._lastname = value;
            }
        }
        private string _phone;
        [NotNull]
        public string phone
        {
            get
            {
                return _phone;
            }
            set
            {
                this._phone = value;
            }
        }
        private string _email;
        [NotNull]
        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                this._email = value;
            }
        }
    }
}
