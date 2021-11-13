using System;
using System.Collections.Generic;
 
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using rect.Models;  


namespace Rect.Controllers
{
    public class EmployeeController: Controller  
    {
        EmployeeDataAccessLayer objmitarbeiter = new EmployeeDataAccessLayer();
        
        [HttpGet]  
        [Route("api/Employee/Index")]  
        public IEnumerable<Employee> Index()  
        {  
            return objmitarbeiter.GetAllEmployees();  
        }  

        [HttpPost]  
        [Route("api/Employee/Create")]  
        public int Create(Employee employee)  
        {  
            return objmitarbeiter.AddEmployee(employee);  
        }  

        [HttpGet]  
        [Route("api/Employee/Details/{id}")]  
        public Employee Details(int id)  
        {  
            //hand-workers
            return objmitarbeiter.GetEmployeeData(id);  
        }  

        [HttpPut]  
        [Route("api/Employee/Edit")]  
        public int Edit(Employee employee)  
        {  
            return objmitarbeiter.UpdateEmployee(employee);  
        }  

        [HttpDelete]  
        [Route("api/Employee/Delete/{id}")]  
        public int Delete(int id)  
        {  
            return objmitarbeiter.DeleteEmployee(id);  
        }  
        /* No Cities DB object 
        [HttpGet]  
        [Route("api/Employee/GetCityList")]  
        public IEnumerable<TblCities> Details()  
        {  
            return objemployee.GetCities();  
        }  */
                
    }
}
