using Basic.Domain.Interfaces;
using Basic.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.DataAccesEF.TypeRepository
{
    public class PatientInfoRepository : GenericRepository<PatientInfoStore>, IPatientInfoStoreRepository
    {
        public PatientInfoRepository(PatientsInfoContext context) : base(context)
        {
        }
    }
}
