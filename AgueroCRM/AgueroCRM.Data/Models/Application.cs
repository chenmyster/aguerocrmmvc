using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgueroCRM.Data
{
    public class Application
    {
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public string University { get; set; }

        public string Programme { get; set; }

        public string Agency { get; set; }

        public string ApplicationType { get; set; }

        public string ApplicationStatus { get; set; }

        public string ReferenceStatus { get; set; }

        public string ChoiceType { get; set; }

        public DateTime ReminderDate { get; set; }

        public string ReminderNotes { get; set; }

        public string OfferConditions { get; set; }

        public DateTime OfferDeadline { get; set; }

        public string LoginId { get; set; }

        public string Password { get; set; }
    }
}
