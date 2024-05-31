using Basic.Domain.Interfaces;
using Basic.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.DataAccesEF.TypeRepository
{
    public class NCDRepository : GenericRepository<NCD>, INCDRepository
    {
        public NCDRepository(PatientsInfoContext context) : base(context)
        {
        }
    }

}
