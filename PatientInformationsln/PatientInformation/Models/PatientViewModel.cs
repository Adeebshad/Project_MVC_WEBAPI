namespace PatientInformation.Models
{
    public class PatientViewModel
    {
        public string PatientName { get; set; }
        public string DiseasesName { get; set; }
        public bool Epilepsy { get; set; }
        public List<string> OtherNCDs { get; set; }
        public List<string> Allergies { get; set; }
    }
}
