using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BeyzanurDuzceEduTr.Models.Entities
{
    [Table("Announcements")]
    public class Announcement
    {
        [Key]
        public int AnnouncementId { get; set; } = default(int);
        public string Subject { get; set; }
        public string Detail { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
