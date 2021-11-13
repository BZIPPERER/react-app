using Microsoft.EntityFrameworkCore;  
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  

/*Suburban Overground*/
namespace rect.Models
{
     public class EmployeeDataAccessLayer
     { 
         // Test On different machine: ERROR 
         private PRACCONContext db = new PRACCONContext();  
         public void writeToHost()
         {
            Console.WriteLine("Transfer");
         }

         // GET all Employee objects
         public IEnumerable<Employee> GetAllEmployees()  
         {  
            try  
            {  
                // try to reach the objects of DB Context class
                return db.Employee.ToList();  
            }  
            catch  
            {  
                throw;  
            }  
         }  
  
         // POST 
         //To Add new employee record     
        public int AddEmployee(Employee employee)  
        {   
            try  
            {  
                db.Employee.Add(employee);  
                db.SaveChanges();  
                return 1;  
            }  
            catch  
            {  
                throw;  
            }  
        }  

        //To Update the records of a particluar employee    
        public int UpdateEmployee(Employee employee)  
        {  
            try  
            {  
                db.Entry(employee).State = EntityState.Modified;  
                db.SaveChanges();  

                return 1;  
            }  
            catch  
            {  
                throw;  
            }  
        }  

        //Get the details of a particular employee    
        public Employee GetEmployeeData(int id)  
        {  
            try  
            {
                // Simple Find(x) 
                Employee employee = db.Employee.Find(id);  
                return employee;  
            }  
            catch  
            {  
                throw;  
            }  
        }  

        //To Delete the record of a particular employee    
        public int DeleteEmployee(int id)  
        {  
            try  
            {  
                Employee emp = db.Employee.Find(id);  
                db.Employee.Remove(emp);  
                db.SaveChanges();  
                return 1;  
            }  
            catch  
            {  
                throw;  
            }  
        }  

        /*To Get the list of Cities    
        public List<TblCities> GetCities()  
        {  
            List<TblCities> lstCity = new List<TblCities>();  
            lstCity = (from CityList in db.TblCities select CityList).ToList();  

            return lstCity;  
        }*/  


     }
}


