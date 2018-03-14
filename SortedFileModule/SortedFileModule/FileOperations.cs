using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Xml;
namespace SortedFileModule
{
    class FileOperations
    {
         static List<Employee> EmployeesList = new List<Employee>();
         static long SSN;
        public long GetSSN()
         {
             return SSN;
         }
        public void Load(){
            if (File.Exists("Employees.xml"))
            {
                XmlSerializer MyXml = new XmlSerializer(EmployeesList.GetType());//GetType->return the type of parameter.
                FileStream fs = new FileStream("Employees.xml", FileMode.Open);
                EmployeesList = (List<Employee>)MyXml.Deserialize(fs);
                fs.Close();
            } 

        }
        public void Save()
        {
            XmlSerializer MyXml = new XmlSerializer(EmployeesList.GetType());//GetType->return the type of parameter.
            FileStream fs = new FileStream("Employees.xml", FileMode.OpenOrCreate);
            //EmployeesList.OrderBy(Employee => Employee.SSN);//to sort the employees within the list by SSN.
            MyXml.Serialize(fs, EmployeesList);
            fs.Close();
        }
        public bool CheckFind(long ssn)
        {
            SSN = ssn;
            if (EmployeesList.Any(Employee => Employee.SSN == ssn))//to search with an attribute in class in list of classes.
                return true;
            else
                return false;
        }
        public void Add(Employee emp)//add an employee to my list after check.
        {
            if (CheckFind(emp.SSN) == false)
            {
                EmployeesList.Add(emp);
                Save();
                MessageBox.Show("Successfully Added");
            }
            else
                MessageBox.Show("Already Exist!!!");

        }
        public void Delete(long ssn)
        {
            if (CheckFind(ssn) == true)
            {
                EmployeesList.RemoveAll(Employee => Employee.SSN == ssn);//remove all object have the ssn.
                Save();
                MessageBox.Show("Successfully Deleted");
            }
            else
                MessageBox.Show("Not Exist!!!");
        }
        public Employee FindEmployee(long ssn)
        {
           // MessageBox.Show(EmployeesList.Find(Employee => Employee.SSN == ssn).SSN.ToString());
            return EmployeesList.Find(Employee => Employee.SSN == ssn);
        }
        public void Update(long ssn, Employee emp)
        {
            EmployeesList.RemoveAll(Employee => Employee.SSN == ssn);
            EmployeesList.Add(emp);
            Save();
            MessageBox.Show("Successfully Updated");
        }
        public void Display(DisplayForm form)
        {
            //DisplayForm form = new DisplayForm();
            for (int i = 0; i < EmployeesList.Count; i++) 
            {
                form.Emplyees_dataGrid.Rows.Add(EmployeesList[i].SSN.ToString(), EmployeesList[i].FName, EmployeesList[i].LName, EmployeesList[i].Salary.ToString(), EmployeesList[i].Phone.ToString(), EmployeesList[i].Department, EmployeesList[i].Gender);
            }
            
        }
        public void Sort(String type) {
            XmlSerializer MyXml = new XmlSerializer(EmployeesList.GetType());
            FileStream fs = new FileStream("Employees.xml", FileMode.OpenOrCreate);
            if (type == "SSN")
            {
                //EmployeesList.OrderBy(Employee => Employee.SSN);
                //EmployeesList.Sort((employee, employee1) => (int) employee.SSN);
                MessageBox.Show("The File Sorted by SSN");
            }
            else if (type == "FName")
            {
                EmployeesList.OrderBy(Employee => Employee.FName);
                MessageBox.Show("The File Sorted by FName");
            }
            else if (type == "LName")
            {
                EmployeesList.OrderBy(Employee => Employee.LName);
                MessageBox.Show("The File Sorted by LName");
            }
            else if (type == "Department")
            {
                EmployeesList.OrderBy(Employee => Employee.Department);
                MessageBox.Show("The File Sorted by Department");
            }
            else if (type == "Phone")
            {
                EmployeesList.OrderBy(Employee => Employee.Phone);
                MessageBox.Show("The File Sorted by Phone");
            }
            else if (type == "Salary")
            {
                EmployeesList.OrderBy(Employee => Employee.Salary);
                MessageBox.Show("The File Sorted by Salary");
            }

            MyXml.Serialize(fs, EmployeesList);
            
            fs.Close();
        
        }

    }
}
