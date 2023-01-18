using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Doctor
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
    }
}
