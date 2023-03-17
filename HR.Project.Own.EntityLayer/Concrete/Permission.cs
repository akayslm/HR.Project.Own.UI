using HR.Project.Own.EntityLayer.Abstract;
using HR.Project.Own.EntityLayer.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Project.Own.EntityLayer.Concrete
{
    public class Permission : BaseEntity
    {
        public int PermissionId { get; set; }              
        public double PermissionDay { get; set; }

        public DateTime PermissionStartDate { get; set; }
        public DateTime PermissionEndDate { get; set; }
        public string Description { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; }

        public PermissionType PermissionType { get; set; }
        public Permission()
        {
            PermissionEndDate = PermissionStartDate.AddDays(PermissionDay);
        }
    }
}
