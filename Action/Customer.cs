using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace Action
{
    public class Customer
    {
        public Entity.Customer GetCustomer(int customerId)
        {
            Entity.Customer customer = new Entity.Customer();
            SpParameter queryExecute = new SpParameter("SP_GET_CUSTOMER_SELECT"); // sp ismini yazıyoruz
            queryExecute.Int("@CUSTOMER_ID", customerId);
            DbQueryExecute execute = new DbQueryExecute();
            SqlDataReader reader = execute.ExecuteReader(queryExecute);
            while (reader.Read())
            {
                customer = new Entity.Customer()
                {
                    CustomerId = (int)reader["CUSTOMER_ID"],
                    Iban = reader["IBAN"].ToString(),
                    AccountName = reader["ACCOUNT_NAME"].ToString(),
                    AccountSurname = reader["ACCOUNT_SURNAME"].ToString(),
                    AccountBlok = (bool)reader["ACCOUNT_BLOK"],
                    Balance = (decimal)reader["BALANCE"]
                };
            };
            return customer;
        }
        public Entity.Customer B_BankGetCustomer(int customerId)
        {
            Entity.Customer customer = new Entity.Customer();
            SpParameter queryExecute = new SpParameter("SP_GET_B_BANK_CUSTOMER_SELECT"); // sp ismini yazıyoruz
            queryExecute.Int("@CUSTOMER_ID", customerId);
            DbQueryExecute execute = new DbQueryExecute();
            SqlDataReader reader = execute.ExecuteReader(queryExecute);
            while (reader.Read())
            {
                customer = new Entity.Customer()
                {
                    CustomerId = (int)reader["CUSTOMER_ID"],
                    Iban = reader["IBAN"].ToString(),
                    AccountName = reader["ACCOUNT_NAME"].ToString(),
                    AccountSurname = reader["ACCOUNT_SURNAME"].ToString(),
                    AccountBlok = (bool)reader["ACCOUNT_BLOK"],
                    Balance = (decimal)reader["BALANCE"]
                };
            };
            return customer;
        }
    }
}
