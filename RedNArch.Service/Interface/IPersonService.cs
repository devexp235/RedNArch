using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedNArch.Model.Model;
using RedNArch.Repository.Interface;

namespace RedNArch.Service.Interface
{
    public interface IPersonService : IEntityService<Person>
    {
        Person GetById(long Id);
    }
}
