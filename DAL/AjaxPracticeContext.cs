using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AjaxPractice.Models;

namespace AjaxPractice.DAL
{
    public class AjaxPracticeContext: DbContext
    {
        public AjaxPracticeContext(): base("AjaxPracticeContext") {}

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Group> Groups { get; set; }

    }
}