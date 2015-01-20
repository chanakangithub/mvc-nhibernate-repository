using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infrastructure.Domain;
using NHibernate;
using NHibernate.Linq;
using Infrastructure.UnitOfWork;

namespace Repository.NHibernate.Repositories
{
    public abstract class Repository<T, TId> : IRepository<T, TId>
        where T : class
    {
        private readonly IUnitOfWork _unitOfWork;

        public Repository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // Implement
        public virtual T FindById(TId id)
        {
            return Session.Get<T>(id);
        }

        public virtual void Create(T entity)
        {
            Session.SaveOrUpdate(entity);
        }

        public virtual void Modify(T entity)
        {
            Session.Update(entity);
        }

        public virtual void Delete(T entity)
        {
            Session.Delete(entity);
        }

        public virtual IEnumerable<T> FindAll()
        {
            return Session.Query<T>().ToList();
        }

        protected ISession Session
        {
            get { return SessionFactory.GetCurrentSession(); }
        }

        protected IUnitOfWork UnitOfWork
        {
            get { return _unitOfWork; }
        }
    }
}
