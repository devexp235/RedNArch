using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedNArch.Model.Model;
using RedNArch.Repository.Interface;

namespace RedNArch.Service.Interface
{
    public interface IEntityService<T>: IService where T : BaseEntity
    {
        void Create(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        void Update(T entity);
    }
}
