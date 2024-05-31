using Basic.DataAccesEF.TypeRepository;
using Basic.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.DataAccesEF.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private PatientsInfoContext patientsInformationContext;

        public UnitOfWork(PatientsInfoContext patientsInformationContext)
        {
            this.patientsInformationContext = patientsInformationContext;
            Allergies = new AllergiesRepository(this.patientsInformationContext);
            NCD = new NCDRepository(this.patientsInformationContext);
            Diseases = new DiseaseRepository(this.patientsInformationContext);
            PatientInfoStore = new PatientInfoRepository(this.patientsInformationContext);
        }

        public IAllergiesRepository Allergies
        {
            get;
            private set;
        }

        public INCDRepository NCD
        {
            get;
            private set;
        }

        public IDiseasesRepository Diseases
        {
            get;
            private set;
        }

        public IPatientInfoStoreRepository PatientInfoStore { get; private set; }

        public void Dispose()
        {
            patientsInformationContext.Dispose();
        }
        public int Save()
        {
            return patientsInformationContext.SaveChanges();
        }
    }
}
