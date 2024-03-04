namespace DbClasses.Models
{
    public class MedHistoryEntities
    {
        public int id { get; set; }
        public virtual DiagnosisEntities diagnos { get; set; }
    }
}

