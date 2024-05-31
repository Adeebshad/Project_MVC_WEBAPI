using Microsoft.AspNetCore.Mvc.Rendering;

namespace PatientInformation.Models
{
    public class DiseaseModel
    {
        public List<SelectListItem> Diseases { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
