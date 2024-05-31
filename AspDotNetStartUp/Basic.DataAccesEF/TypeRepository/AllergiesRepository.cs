using Basic.Domain.Interfaces;
using Basic.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.DataAccesEF.TypeRepository
{
    internal class AllergiesRepository : GenericRepository<Allergies>, IAllergiesRepository
    {
        public AllergiesRepository(PatientsInfoContext context) : base(context)
        {
        }
    }
}
