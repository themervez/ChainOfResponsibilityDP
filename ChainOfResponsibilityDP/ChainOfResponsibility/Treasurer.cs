using ChainOfResponsibilityDP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDP.ChainOfResponsibility
{
    public class Treasurer:Employee
    {
      public override void ProcessRequest(WithdrawViewModel p)
        {
            //if (p.Amount <= 40000)
            //{
            //    using(var context=new Context())
            //    {
            //        p.EmployeeName = "Veznedar - Ahmet Yıldız";
            //        p.Description = "Müşteriye talep etmiş olduğu tutarın ödemesi gerçekleştirildi";
            //        context.BankProcesses.Add(p);
            //        context.SaveChanges();
            //    }
            //    //Db'ye Kaydetme
            //    //Console.WriteLine("{0} tarafından para çekme i��lemi onaylandı #{1}",
            //    //    this.GetType().Name, p.Amount);
            //}
            //else if (NextApprover != null)
            //{
            //    Console.WriteLine("{0} TL işlem tutarı {1} max. limitini aştığından işlem yöneticiye gönderildi.", p.Amount, this.GetType().Name);

            //    NextApprover.ProcessRequest(p);
            //}
        }
    }
}
