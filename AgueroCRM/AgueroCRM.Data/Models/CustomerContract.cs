using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgueroCRM.Data.Models
{
    public class CustomerContract
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "客户")]
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        public IEnumerable<Customer> Customers { get; set; }

        [Display(Name = "顾问")]
        public string Counselor { get; set; }

        [Display(Name = "开始日期")]
        public DateTime StartDate { get; set; }

        [Display(Name = "货币")]
        public string Currency { get; set; }

        [Display(Name = "价格")]
        public int ContractPrice { get; set; }

        [Display(Name = "付款时间")]
        public DateTime PaymentDate { get; set; }

        [Display(Name = "付款方式")]
        public string PaymentMethod { get; set; }
    }
}
