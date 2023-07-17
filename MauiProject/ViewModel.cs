using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiProject
{
    public class ViewModel
    {
        public EmployeeInfo Employee { get; set; }
        
        public ViewModel() { 
            this.Employee = new EmployeeInfo();    
        }
    }
}
