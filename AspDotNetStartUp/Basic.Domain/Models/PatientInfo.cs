using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Domain.Models
{
    public class PatientInfo
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string DiseasesName { get; set; }
        public bool Epilepsy { get; set; }
        public List<string> OtherNCDs { get; set; }
        public List<string> Allergies { get; set; }
    }
}
