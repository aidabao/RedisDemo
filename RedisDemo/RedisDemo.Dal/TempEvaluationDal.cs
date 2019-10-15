using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedisDemo.Common;
using RedisDemo.Common.Domain;

namespace RedisDemo.Dal
{
    public class TempEvaluationDal:BaseDal
    {
        public IList<TempEvaluation> GetList()
        {
            var tempEvaluationList = GetList<TempEvaluation>();
            return tempEvaluationList;
        }
    }
}
