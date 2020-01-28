using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace assign01.Models
{
    public class Student
    {
        public string name { get; set; }
        public string id { get; set; }
        public string age { get; set; }
        public Student() {
            this.name = "";
            this.id = "";
            this.age = "";
        }
    }
}