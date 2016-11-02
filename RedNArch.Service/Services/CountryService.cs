using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedNArch.Model;
using RedNArch.Repository;
using RedNArch.Model.Model;
using RedNArch.Repository.Interface;
using RedNArch.Service.Interface;

namespace RedNArch.Service.Services
{
    public class CountryService : EntityService<Country>, ICountryService
    {
        IUnitOfWork _UnitOfWork;
        ICountryRepository _countryRepository;

        public CountryService(IUnitOfWork UnitOfWork, ICountryRepository countryRepository):base(UnitOfWork, countryRepository)
        {
            _UnitOfWork = UnitOfWork;
            _countryRepository = countryRepository;
        }
        public Country GetById(int Id)
        {
            return _countryRepository.GetById(Id);
        }
    }
}
