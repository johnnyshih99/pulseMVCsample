using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PulseTemp.Models
{
    public class Template
    {
        public int ID { get; set; }
        [Display(Name = "Your Name")]
        public string name { get; set; }
        [Display(Name = "Your Address")]
        public string addr { get; set; }
        [Display(Name = "First Name")]
        public string fName { get; set; }
        [Display(Name = "Last Name")]
        public string lName { get; set; }
        [Display(Name = "Home Town")]
        public string hometown { get; set; }
        [Display(Name = "Spouse's Name")]
        public string spouse { get; set; }
        [Display(Name = "Kid's Name #1")]
        public string kid1 { get; set; }
        [Display(Name = "Kid's Name #2")]
        public string kid2 { get; set; }
    }

    public class TemplatesDBContext : DbContext
    {
        public DbSet<Template> Templates { get; set; }
    }
}