using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime TreatmentStart { get; set; }
        public DateTime TreatmentEnd { get; set; }
    }
}
