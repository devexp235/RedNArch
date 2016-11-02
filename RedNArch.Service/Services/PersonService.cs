using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedNArch.Model.Model;
using RedNArch.Repository.Interface;
using RedNArch.Service.Interface;

namespace RedNArch.Service.Services
{
    public class PersonService : EntityService<Person>, IPersonService
    {
        IUnitOfWork _UnitOfWork;
        IPersonRepository _personRepository;
        
        public PersonService(IUnitOfWork UnitOfWork, IPersonRepository personRepository):base(UnitOfWork, personRepository)
        {
            _UnitOfWork = UnitOfWork;
            _personRepository = personRepository;
        }
        public Person GetById(long Id)
        {
            return _personRepository.GetById(Id);
        }
    }
}
