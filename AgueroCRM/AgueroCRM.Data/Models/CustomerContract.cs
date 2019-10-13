using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgueroCRM.Data.Models
{
    public class CustomerContract
    {
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public string Counselor { get; set; }

        public DateTime StartDate { get; set; }

        public string ContractPrice { get; set; }

        public DateTime PaymentDate { get; set; }

        public string PaymentMethod { get; set; }
    }
}
