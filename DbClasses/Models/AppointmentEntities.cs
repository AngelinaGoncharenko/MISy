namespace DbClasses.Models
{
    public class AppointmentEntities
    {
        public int id { get; set; }
        public DateTime last { get; set; }
        public DateTime next { get; set; }
        public virtual DoctorEntities doctor { get; set; }
        public virtual LDEntities ldentities { get; set; }

    }
}

