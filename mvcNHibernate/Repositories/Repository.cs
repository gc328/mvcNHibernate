﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;

using mvcNHibernate.Modules;
using NHibernate;
using NHibernate.Linq;

namespace mvcNHibernate.Repositories
{
    public class Repository<T> : IRepository<T>
    {
        private readonly ISession session;

        public Repository()
        {
            session = NHibernateSessionPerRequest.GetCurrentSession();
        }

        public IQueryable<T> GetAll()
        {
            return session.Query<T>();
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }

        public IEnumerable<T> SaveOrUpdateAll(params T[] entities)
        {
            foreach (var entity in entities)
            {
                session.SaveOrUpdate(entity);
            }

            return entities;
        }

        public T SaveOrUpdate(T entity)
        {
            session.SaveOrUpdate(entity);

            return entity;
        }

        public void Delete(T entity)
        {
            session.Delete(entity);
        }
    }
}