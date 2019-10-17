using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedisDemo.Common;
using RedisDemo.Common.Domain;
using RedisDemo.Dal.IDal;

namespace RedisDemo.Dal
{
    public partial class TempEvaluationDal :ITempEvaluationDal
    {
        public IList<TempEvaluation> GetList()
        {
            var tempEvaluationList = GetList<TempEvaluation>();
            return tempEvaluationList;
        }
    }
    public partial class TempEvaluationDal : BaseDal
    {

    }
}
