using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flows.ServiceHost.DataModel

{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public int EmailAddress { get; set; }
        public bool IsActive { get; set; }
    }
}
