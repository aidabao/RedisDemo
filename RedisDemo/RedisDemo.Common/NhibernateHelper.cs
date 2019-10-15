using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
namespace RedisDemo.Common
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        public static ISessionFactory SessionFactory
        {
            get
            {
                //配置ISessionFactory
                return _sessionFactory == null ? (new Configuration()).Configure().BuildSessionFactory() : _sessionFactory;
            }
        }
    }
}

