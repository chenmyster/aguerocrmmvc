using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgueroCRM.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        public string Status { get; set; }

        public string University { get; set; }

        public string Grade { get; set; }

        public string Programme { get; set; }

        public string WechatId { get; set; }

        public string Mobile { get; set; }

        public string PersonalEmail { get; set; }

        public string ApplicationEmail { get; set; }

        public string MarketingSource { get; set; }

        public string Referal { get; set; }

        public DateTime ReminderDate { get; set; }

        public string ReminderNotes { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string ContactAddress { get; set; }

        public string HomeAddress { get; set; }
    }
}
