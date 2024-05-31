using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Domain.Models
{
    public class PatientInfoStore
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string DiseasesName { get; set; }
        public bool Epilepsy { get; set; }
        public List<OtherNCD> OtherNCDs { get; set; }
        public List<OtherAllergy> Allergies { get; set; }
    }

    public class OtherNCD
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PatientInfoId { get; set; }
        public PatientInfoStore PatientInfoStore { get; set; }
    }

    public class OtherAllergy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PatientInfoId { get; set; }
        public PatientInfoStore PatientInfoStore { get; set; }
    }
}
