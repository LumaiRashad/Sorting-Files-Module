using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Xml.Serialization;
namespace SortedFileModule
{
    
   public class Employee
   {
        public long SSN { get; set; }
        public String FName { get; set; }
        public String LName { get; set; }
        public long Salary { get; set; }
        public long Phone { get; set; }
        public String Department { get; set; }
        public String Gender { get; set; }
       
        public Employee(long phone, string fName, string lName, long ssn, long salary, string gender, string department)
        {
            Phone = phone;
            FName = fName;
            LName = lName;
            SSN = ssn;
            Salary = salary;
            Gender = gender;
            Department = department;
        
        }
        public Employee()
        {
            Phone = Salary = SSN = 0;
            FName = LName = Gender = Department = "";

        }
    
}
}
