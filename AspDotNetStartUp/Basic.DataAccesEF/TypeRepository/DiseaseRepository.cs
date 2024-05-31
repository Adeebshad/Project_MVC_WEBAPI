using Basic.Domain.Interfaces;
using Basic.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.DataAccesEF.TypeRepository
{
    public class DiseaseRepository : GenericRepository<Diseases>, IDiseasesRepository
    {
        public DiseaseRepository(PatientsInfoContext context) : base(context)
        {
        }
    }
}
