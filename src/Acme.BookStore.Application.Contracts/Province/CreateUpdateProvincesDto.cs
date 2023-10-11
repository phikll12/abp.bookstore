using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.BookStore.Province;

public class CreateUpdateProvincesDto
{
    [Required]
    [StringLength(250)]
    public string provinceName { get; set; }
    public string description { get; set; }
    [Required]
    public bool isActive { get; set; }
}
