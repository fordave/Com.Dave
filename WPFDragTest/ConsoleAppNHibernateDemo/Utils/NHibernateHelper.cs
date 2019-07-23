using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppNHibernateDemo.Utils
{
    public class NHibernateHelper<T> where T : class
    {
        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var cfg = new Configuration();
                    cfg.Configure();
                    //构建nhibernate
                    _sessionFactory = cfg.BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }

        #region crud
        public int Insert(T emp)
        {
            using (var session = SessionFactory.OpenSession())
            {
                var i = session.Save(emp);
                session.Flush();//相当于savechange
                return Convert.ToInt32(i);
            }
        }
        public void Delete(int id)
        {
            using (var session = SessionFactory.OpenSession())
            {
                var entity = session.Load<T>(id);
                session.Delete(entity);
                session.Flush();
            }
        }
        public void Update(T emp)
        {
            using (var session = SessionFactory.OpenSession())
            {
                session.SaveOrUpdate(emp);
                session.Flush();
            }
        }
        public T GetById(int id)
        {
            using (var session = SessionFactory.OpenSession())
            {
                var emp = session.Get<T>(id);
                return emp;
            }
        }
        public IList<T> GetAll()
        {
            using (var session = SessionFactory.OpenSession())
            {
                var emps = session.CreateCriteria<T>().List<T>();
                return emps;
            }
        }
        #endregion
    }
}
