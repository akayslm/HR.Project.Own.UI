using HR.Project.Own.EntityLayer.Abstract;
using HR.Project.Own.EntityLayer.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Project.Own.EntityLayer.Concrete
{
    public class Advance : BaseEntity
    {
        public int AdvanceId { get; set; }
        public decimal AdvanceAmount { get; set; }
        public DateTime AdvanceRequestDate { get; set; }
        public DateTime? AdvanceConfirmDate { get; set; }
        public string Description { get; set; }

        public ApprovalStatus ApprovalStatus { get; set; }
        public Currency Currency { get; set; }
        public AdvanceType AdvanceType { get; set; }
    }
}
