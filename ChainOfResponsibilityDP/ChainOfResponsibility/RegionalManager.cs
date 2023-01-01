using ChainOfResponsibilityDP.DAL;
using ChainOfResponsibilityDP.DAL.Entities;
using ChainOfResponsibilityDP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDP.ChainOfResponsibility
{
    public class RegionalManager : Employee
    {
        public override void ProcessRequest(WithdrawViewModel req)
        {
            Context context = new Context();
            BankProcess bankProcess = new BankProcess();
            if (req.Amount <= 250000)
            {
                bankProcess.EmployeeName = "Bölge Müdürü - Güneş Kaya";
                bankProcess.Description = "Müşteriye talep etmiş olduğu tutarın ödemesi Şube Müdürü tarafından gerçekleştirildi.";
                bankProcess.Amount = req.Amount;
                bankProcess.CustomerName = req.CustomerName;
                context.BankProcesses.Add(bankProcess);
                context.SaveChanges();
            }
            else
            {
                bankProcess.EmployeeName = "Bölge Müdürü - Güneş Kaya";
                bankProcess.Description = "Müşterinin talep ettiği tutar banka limitlerinin günlük çekim tutarı üzerinde olduğu için müşteriye ödeme yapılamamıştır.";
                bankProcess.Amount = req.Amount;
                bankProcess.CustomerName = req.CustomerName;
                context.BankProcesses.Add(bankProcess);
                context.SaveChanges();
            }
        }
    }
}
