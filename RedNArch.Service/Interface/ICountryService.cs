using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedNArch.Model;
using RedNArch.Repository;
using RedNArch.Model.Model;
using RedNArch.Repository.Interface;


namespace RedNArch.Service.Interface
{
    public interface ICountryService : IEntityService<Country>
    {
        Country GetById(int Id);
    }
}
