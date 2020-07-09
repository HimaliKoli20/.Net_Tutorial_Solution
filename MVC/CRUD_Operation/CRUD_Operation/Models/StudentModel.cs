using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_Operation.Models
{
    public class StudentModel
    {
        public int ID { get; set; }

        [DisplayName("Student Name")]
        public string SName { get; set; }
        
        [DisplayName("Phone Number")]
        public double MobNo { get; set; }
        public int Marks { get; set; }
    }
}