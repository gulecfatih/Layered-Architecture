using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Action;
using Entity;
namespace KatmanliMimari
{
    public class Program
    {
        static void Main(string[] args)
        {
            Action.Customer customer = new Action.Customer();
            Action.Transfer transfer = new Action.Transfer();
            ButtonClickTransfer(customer, transfer);
        }

        public static void ButtonClickTransfer(Action.Customer customer, Transfer transfer)
        {
            Random rnd = new Random();
            int customerId = 1; // rnd.Next(1);

            Entity.Customer Entitycustomer = customer.GetCustomer(customerId);


            TransferInfo Entitytransfer = new TransferInfo();
            Entitytransfer = new TransferInfo
            {
                CustomerId = Entitycustomer.CustomerId,
                AccountName = Entitycustomer.AccountName,
                AccountSurname = Entitycustomer.AccountSurname,
                Amount = 500,
                CustomerName = "Fatih",
                CustomerSurname = "Güleç",
                Iban = "TR9060870065551236",

            };
            if (Entitytransfer.Amount > Entitycustomer.Balance)
            {
                Console.WriteLine("Hesap Bakiyeniz Göndermeye Çalıştığınız Tutardan Az Olduğu için Gönderim Gerçekleştirilememiştir");
                return;
            }
            if (Entitycustomer.AccountBlok)
            {
                Console.WriteLine("Hesap Bloklu Olduğundan Gönderim İşlemi Gerçekleştirilemiyor");
                return;
            }

            Entitytransfer.Id = Convert.ToInt32(transfer.ActionTransfer(Entitytransfer));

            /////// B bankasının kendi içinde servisinin olduğunu düşünelim ve TransactionIsSuccessful sutunda parayı kabul edip etmediğini işlediğini görelim
            Entity.Customer B_BankEntitycustomer = customer.B_BankGetCustomer(Entitytransfer.CustomerId);

            if (Entitytransfer.CustomerName == B_BankEntitycustomer.AccountName &&
                Entitytransfer.CustomerSurname == B_BankEntitycustomer.AccountSurname &&
                Entitytransfer.Iban == B_BankEntitycustomer.Iban
                )
            {
                transfer.ActionTransferUpdate(Entitytransfer, true); // transfer başarılı olduğu için TransactionIsSuccessful kodunu true yapıyoruz
            }
            else
            {
                transfer.ActionTransferUpdate(Entitytransfer, false); // transfer başarısız olduğu için TransactionIsSuccessful kodunu false yapıyoruz
            }

            /////// B bankasının kendi içinde servisinin olduğunu düşünelim ve bir sutunda parayı kabul edip etmediğini işlediğini görelim


           


        }

    }
}
