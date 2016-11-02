using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RedNArch.Model.Model;
using RedNArch.Repository.Interface;

namespace RedNArch.Repository.Repository
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(DbContext context) : base(context)
        {

        }
        public Country GetById(int Id)
        {
            return FindBy(x => x.Id == Id).FirstOrDefault();
        }
    }
}
