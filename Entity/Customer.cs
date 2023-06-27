using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Customer
    {
        /// <summary>
        /// Customer Id
        /// </summary>
        public int CustomerId { get; set; }
        /// <summary>
        /// Iban
        /// </summary>
        public string Iban { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string AccountName { get; set; }
        /// <summary>
        /// SurName
        /// </summary>
        public string AccountSurname { get; set; }
        /// <summary>
        /// Hesap Bakiyesi
        /// </summary>
        public decimal Balance { get; set; }
        /// <summary>
        /// Blok Konulmuş mu Kontrol
        /// </summary>
        public bool AccountBlok { get; set; }

    }
}
