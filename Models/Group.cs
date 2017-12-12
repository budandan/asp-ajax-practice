using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AjaxPractice.Models
{
    [Table("Group")]
    public class Group
    {
        [Key]
        public int GroupID { get; set; }
        public String GroupName { get; set; }
        public int SupervisorID { get; set; }
    }
}