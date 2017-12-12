using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AjaxPractice.Models
{
    [Table("Staff")]
    public class Staff
    {
        [Key]
        public int StaffID { get; set; }
        public int GroupID { get; set; }
        public String Name { get; set; }
    }
}