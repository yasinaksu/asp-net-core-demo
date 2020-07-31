using AspNetCoreMvc2.Introduction.Entities;
using System.Collections.Generic;

namespace AspNetCoreMvc2.Introduction.Models
{
    public class EmployeeListViewModel
    {
        public EmployeeListViewModel()
        {

        }
        public List<Employee> Employees { get; set; }
    }
}