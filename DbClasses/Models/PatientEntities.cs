using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbClasses.Models
{
    public class PatientEntities
    {
        public int id { get; set; }
        public string name { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string pasport { get; set; }
        public DateTime dateBirth { get; set; }
        public virtual GenderEntities gender { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public virtual MedCardEntities medCard { get; set; }
        public string policy { get; set; }
        public string снилс { get; set; }
        public virtual GovEntities gov { get; set; }
        public DateTime dateEndPolicy { get; set; }
        public virtual MedHistoryEntities medHistory { get; set; }
        public string insuranceCompany { get; set; }
        public string work { get; set; }

    }
}

