using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eflyer.Core.Models
{
    public class Electronic : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; } = null!;
        public int Privce {  get; set; }
        public string? ImageUrl { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }    
    }
}
