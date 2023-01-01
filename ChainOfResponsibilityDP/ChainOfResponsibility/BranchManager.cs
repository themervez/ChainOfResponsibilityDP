using ChainOfResponsibilityDP.DAL;
using ChainOfResponsibilityDP.DAL.Entities;
using ChainOfResponsibilityDP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDP.ChainOfResponsibility
{
    public class BranchManager : Employee
    {
        public override void ProcessRequest(WithdrawViewModel req)
        {
            Context context = new Context();
            BankProcess bankProcess = new BankProcess();
            if (req.Amount <= 150000)
            {
                bankProcess.EmployeeName = "Şube Müdürü - Elif Öz";
                bankProcess.Description = "Müşteriye talep etmiş olduğu tutarın ödemesi Şube Müdürü tarafından gerçekleştirildi.";
                bankProcess.Amount = req.Amount;
                bankProcess.CustomerName = req.CustomerName;
                context.BankProcesses.Add(bankProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                bankProcess.EmployeeName = "Şube Müdürü - Elif Öz";
                bankProcess.Description = "Müşterinin talep ettiği tutar yetkim dahilinde olmadığı için işlem yetkilisi Bölge Müdürü olarak güncellendi.";
                bankProcess.Amount = req.Amount;
                bankProcess.CustomerName = req.CustomerName;
                context.BankProcesses.Add(bankProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
