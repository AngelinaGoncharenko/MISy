namespace DbClasses.Models
{
    public class LDEntities
    {
        public int id { get; set; }
        public string name { get; set; }
        public string results { get; set; }
        public string recomendations { get; set; }
        public virtual PatientEntities patient { get; set; }
        public virtual DoctorEntities doctor { get; set; }
        public virtual TypeEventEntities typeEvent { get; set; }
    }
}

