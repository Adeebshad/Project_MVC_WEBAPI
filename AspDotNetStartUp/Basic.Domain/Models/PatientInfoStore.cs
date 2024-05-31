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
        public int DiseasesId { get; set; }
        public bool Epilepsy { get; set; }
        public List<NCD_Details> NCDs{ get; set; }
        public List<Allergies_Details> Allergies { get; set; }
    }

    public class NCD_Details
    {
        public int Id { get; set; }
        public int NCDId { get; set; }
        public int PatientInfoId { get; set; }
        public PatientInfoStore PatientInfoStore { get; set; }
    }

    public class Allergies_Details
    {
        public int Id { get; set; }
        public int AllergyId { get; set; }
        public int PatientInfoId { get; set; }
        public PatientInfoStore PatientInfoStore { get; set; }
    }
}
