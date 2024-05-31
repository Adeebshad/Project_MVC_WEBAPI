using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {        //IAdressRepository Address
        //{
        //    get;
        //}
        //IEmailRepository Email
        //{
        //    get;
        //}
        //IPersonRepository Person
        //{
        //    get;
        //}



        IAllergiesRepository Allergies { get; }
        INCDRepository NCD { get; }
        IDiseasesRepository Diseases { get; }
        IPatientInfoStoreRepository PatientInfoStore { get; }
        int Save();
    }
}
