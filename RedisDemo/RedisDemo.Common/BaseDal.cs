using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;

namespace RedisDemo.Common
{
    public class BaseDal
    {
        public IList<T> GetList<T>() where T:class
        {
            var tList = new List<T>();
            try
            {
                // 创建会话
                using (ISession session = NHibernateHelper.SessionFactory.OpenSession())
                {
                    var linq = from p in session.Query<T>()
                               select p;
                    tList = linq.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tList;
        }
    }
}
