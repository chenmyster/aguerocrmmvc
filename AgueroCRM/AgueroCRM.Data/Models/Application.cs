using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgueroCRM.Data.Models
{
    public class Application
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "客户")]
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        public IEnumerable<Customer> Customers { get; set; }

        [Display(Name = "大学")]
        public string University { get; set; }

        [Display(Name = "科目")]
        public string Programme { get; set; }

        [Display(Name = "中介")]
        public string Agency { get; set; }

        [Display(Name = "申请类型")]
        public string ApplicationType { get; set; }

        [Display(Name = "申请状态")]
        public string ApplicationStatus { get; set; }

        [Display(Name = "Reference状态")]
        public string ReferenceStatus { get; set; }

        [Display(Name = "选择类型")]
        public string ChoiceType { get; set; }

        [Required, DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name = "提醒日期")]
        public DateTime ReminderDate { get; set; }

        [Display(Name = "提醒内容")]
        public string ReminderNotes { get; set; }

        [Display(Name = "Offer条件")]
        public string OfferConditions { get; set; }


        [Required, DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name = "Offer期限")]
        public DateTime OfferDeadline { get; set; }

        [Display(Name = "账号")]
        public string LoginId { get; set; }

        [Display(Name = "密码")]
        public string Password { get; set; }
    }
}
