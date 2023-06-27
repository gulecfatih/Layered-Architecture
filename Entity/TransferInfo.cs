using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TransferInfo
    {
        /// <summary>
        /// Transaction Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Karşı Tarafın Iban
        /// </summary>
        public string Iban { get; set; }
        /// <summary>
        /// Müşteri Id
        /// </summary>
        public int CustomerId { get; set; }
        /// <summary>
        /// Hesap Sahibinin Adi
        /// </summary>
        public string AccountName { get; set; }
        /// <summary>
        /// Hesap Sahibinin Soy Adi
        /// </summary>
        public string AccountSurname { get; set; }
        /// <summary>
        /// Tutar
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Karşıdaki Müşterinin Adı
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// Karşıdaki Müşterinin Soy Adi
        /// </summary>
        public string CustomerSurname { get;set; }
        /// <summary>
        /// Karşıdaki Müşterinin Soy Adi
        /// </summary>
        public bool TransactionIsSuccessful { get; set; }

    }
}
