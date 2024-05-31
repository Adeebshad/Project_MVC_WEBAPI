namespace PatientInformation.Models
{
    public class PatientInfo

    {
        public string PatientName { get; set; }
        public int DiseasesName { get; set; }
        public bool Epilepsy { get; set; }
        public List<int> OtherNCDs { get; set; }
        public List<int> Allergies { get; set; }
    }
}
