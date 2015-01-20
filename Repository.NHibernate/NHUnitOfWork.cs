using Infrastructure.UnitOfWork;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.NHibernate
{
    public class NHUnitOfWork : IUnitOfWork
    {
        private ISession _session;
        private ITransaction _transaction;

        private ISession Session
        {
            get
            {
                if (_session == null)
                {
                    _session = SessionFactory.GetCurrentSession();
                    _transaction = _session.BeginTransaction();
                }

                return _session;
            }
        }

        public void Dispose()
        {
            if (_transaction != null)
                _transaction.Rollback();
        }

        public void Commit()
        {
            if (_transaction == null)
                throw new InvalidOperationException("UnitOfWork have already been saved.");

            _transaction.Commit();
            _transaction = null;
        }
    }
}
