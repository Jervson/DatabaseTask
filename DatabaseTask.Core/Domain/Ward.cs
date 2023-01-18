using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Ward
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int RoomNr { get; set; }
        public string PatientName { get; set; }
    }
}
