using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace Action
{
    public class Transfer
    {
        /// <summary>
        /// Transfer İşleminin Gerçekleşmesini Sağlayan Action
        /// </summary>
        /// <param name="transfer"></param>
        /// <returns></returns>
        public object ActionTransfer(TransferInfo transfer)
        {
            SpParameter queryExecute = new SpParameter("TRANSFER_PROCESS_INSERT"); // sp ismini yazıyoruz
            queryExecute.Int("@CUSTOMER_ID", transfer.CustomerId);
            queryExecute.String("@IBAN", transfer.Iban);
            queryExecute.String("@ACCOUNT_NAME", transfer.AccountName);
            queryExecute.String("@ACCOUNT_SURNAME", transfer.AccountSurname);
            queryExecute.Decimal("@AMOUNT", transfer.Amount);
            queryExecute.String("@CUSTOMER_NAME", transfer.CustomerName);
            queryExecute.String("@CUSTOMER_SURNAME", transfer.CustomerSurname);
            
            DbQueryExecute execute = new DbQueryExecute();
            return execute.ExecuteScalar(queryExecute) ;
        }

        /// <summary>
        /// Transfer İşleminin doğruluğuna göre update işlemi yapar
        /// </summary>
        /// <param name="transfer"></param>
        /// <returns></returns>
        public bool ActionTransferUpdate(TransferInfo transfer,bool Issuccessful)
        {
            SpParameter queryExecute = new SpParameter("TRANSFER_PROCESS_UPDATE"); // sp ismini yazıyoruz
            queryExecute.Int("@ID", transfer.Id);
            queryExecute.Bool("TRANSACTION_IS_SUCCESSFUL", Issuccessful);
            DbQueryExecute execute = new DbQueryExecute();
            return  execute.ExecuteNonQuery(queryExecute);
            
        }



    }

}

