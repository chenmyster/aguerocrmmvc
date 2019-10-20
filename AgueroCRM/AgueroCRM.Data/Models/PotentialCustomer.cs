using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgueroCRM.Data.Models
{
    public class PotentialCustomer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        [Display(Name = "姓名")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "状态")]
        public string Status { get; set; }

        [Display(Name = "大学")]
        public string University { get; set; }

        [Display(Name = "成绩")]
        public string Grade { get; set; }

        [Display(Name = "专业")]
        public string Programme { get; set; }

        [Display(Name = "微信")]
        public string WechatId { get; set; }

        [Display(Name = "电话")]
        public string Mobile { get; set; }

        [Display(Name = "邮箱")]
        public string PersonalEmail { get; set; }

        [Display(Name = "市场")]
        public string MarketingSource { get; set; }

        [Display(Name = "介绍人")]
        public string Referal { get; set; }

        [Required, DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name = "提醒日期")]
        public DateTime ReminderDate { get; set; }

        [Display(Name = "提醒内容")]
        public string ReminderNotes { get; set; }

        [Required, DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name = "生日")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "联系住址")]
        public string ContactAddress { get; set; }

        [Display(Name = "家庭住址")]
        public string HomeAddress { get; set; }
    }
}
