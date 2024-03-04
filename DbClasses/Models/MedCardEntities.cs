namespace DbClasses.Models
{
    public class MedCardEntities
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime createdMC { get; set; }
        public string photoPatients { get; set; }
        public virtual AppointmentEntities appointment { get; set; }
    }
}

