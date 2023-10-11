using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Province
{
    public class ProvincesDto : AuditedEntityDto<Guid>
    {
        public string provinceName { get; set; }
        public string description { get; set; }
        public bool isActive { get; set; }
    }
}
