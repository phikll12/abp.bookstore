using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Province
{
    public class Provinces : AuditedAggregateRoot<Guid>
    {
        public string provinceName { get; set; }
        public string description { get; set; }
        public bool isActive { get; set; }
    }
}
