using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedisDemo.Common.Domain;

namespace RedisDemo.Dal.IDal
{
    public interface ITempEvaluationDal
    {
        IList<TempEvaluation> GetList();
    }
}
