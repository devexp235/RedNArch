using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.Entity;
using RedNArch.Model.Model;
using RedNArch.Model.Interface;

namespace RedNArch.Model.Context
{
    public class RedNArchContext : DbContext
    {
        public RedNArchContext() : base("Name=RedNArchContext")
        { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Country> Countries { get; set; }

        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
                                  .Where(x => x.Entity is IAuditibleEntity
                                  && (x.State == System.Data.Entity.EntityState.Added
                                  || x.State == System.Data.Entity.EntityState.Modified
                                  ));
            foreach(var entry in modifiedEntries)
            {
                IAuditibleEntity entity = entry.Entity as IAuditibleEntity;
                if(entity!= null)
                {
                    string identityName = Thread.CurrentPrincipal.Identity.Name;
                    DateTime now = DateTime.UtcNow;
                    if(entry.State == EntityState.Added)
                    {
                        entity.CreatedBy = identityName;
                        entity.CreatedDate = now;
                    }
                    else
                    {
                        base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                        base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                    }
                    entity.UpdatedBy = identityName;
                    entity.UpdatedDate = now;
                }
            }
            return base.SaveChanges();
        }
    }
}
