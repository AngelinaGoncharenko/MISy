﻿namespace DbClasses.Models
{
    public class DiagnosisEntities
    {
        public int id { get; set; }
        public string recomendationDiagnosis { get; set; }
        public string anamnes { get; set; }
        public string symptoms { get; set; }
        public virtual ReceptEntities recept { get; set; }
    }
}

