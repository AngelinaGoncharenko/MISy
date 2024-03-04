namespace DbClasses.Models
{
    public class HospitalizationEntities
    {
        public int id { get; set; }
        public virtual PatientEntities patient { get; set; }
        public DateTime dateBeginHospitalization { get; set; }
        public DateTime dateEndHospitalization { get; set; }
        public virtual MedHistoryEntities medHistory { get; set; }
        public string target { get; set; }
        public virtual DepartmentEntities department { get; set; }
        public virtual ConditionsHospEntities conditions {get; set;}
        public virtual SolutionHospEntities solution { get; set; }
    }
}

