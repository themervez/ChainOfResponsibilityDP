using ChainOfResponsibilityDP.DAL;
using ChainOfResponsibilityDP.DAL.Entities;
using ChainOfResponsibilityDP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDP.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(WithdrawViewModel req)
        {
            Context context = new Context();
            BankProcess bankProcess = new BankProcess();
            if (req.Amount <= 40000)
            {
                bankProcess.EmployeeName = "Veznedar - Ahmet Yılmaz";
                bankProcess.Description = "Müşteriye talep etmiş olduğu tutarın ödemesi vezne sorumlusu tarafından gerçekleştirildi.";
                bankProcess.Amount=req.Amount;
                bankProcess.CustomerName = req.CustomerName;
                context.BankProcesses.Add(bankProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                bankProcess.EmployeeName = "Veznedar - Ahmet Yılmaz";
                bankProcess.Description = "Müşterinin talep ettiği tutar yetkim dahilinde olmadığı için işlem yetkilisi Şube Operasyon Yöneticisi olarak güncellendi.";
                bankProcess.Amount = req.Amount;
                bankProcess.CustomerName = req.CustomerName;
                context.BankProcesses.Add(bankProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
