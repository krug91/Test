using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationManager.EF.Models
{
    public class Notification
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        [Required]
        [MaxLength(150)]
        public string Title { get; set; }
        [Required]
        [MaxLength(150)]
        public string TitleEN { get; set; }
        [Required]
        [MaxLength(1024)]
        public string Text { get; set; }
        [Required]
        [MaxLength(1024)]
        public string TextEN { get; set; }
        [MaxLength(255)]
        public string Url { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public bool Active { get; set; }
        [MaxLength(255)]
        public string ProductInclude { get; set; }
        [MaxLength(255)]
        public string ProductExclude { get; set; }
        [MaxLength(20)]
        public string ModuleInclude { get; set; }
        [MaxLength(20)]
        public string ModuleExclude { get; set; }

    }
}
