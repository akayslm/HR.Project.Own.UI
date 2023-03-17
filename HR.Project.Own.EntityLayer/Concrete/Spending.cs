using HR.Project.Own.EntityLayer.Abstract;
using HR.Project.Own.EntityLayer.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Project.Own.EntityLayer.Concrete
{
    public class Spending : BaseEntity
    {
        public int SpendingId { get; set; }
        public decimal SpendingAmount { get; set; }
        public string Description { get; set; }
        public DateTime RequestDate { get; set; }

        public ApprovalStatus ApprovalStatus { get; set; }
        public User User { get; set; }
        public SpendingType SpendingType { get; set; }
        public Currency Currency  { get; set; }
    }
}
