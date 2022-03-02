using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MenualNetMVC.Models
{
    public class Student
    {
        [DisplayName("Mã Số")]
        public int ID { get; set; }

        [DisplayName("Họ")]
        public string LastName { get; set; }

        [DisplayName("Tên")]
        public string FirstMidName { get; set; }

        [DisplayName("Ngày nhập học")]
        public DateTime EnrollmentDate { get; set; }

    }
}