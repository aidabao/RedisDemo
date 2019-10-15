using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedisDemo.Bll.IBll;
using RedisDemo.Dal;
using RedisDemo.Common.Domain;

namespace RedisDemo.Bll.Bll
{
    public class TempEvaluationBll:ITempEvaluationBll
    {
        public IList<TempEvaluation> GetList()
        {
            TempEvaluationDal td = new TempEvaluationDal();
            var tempEvaluationList = td.GetList();
            return tempEvaluationList;
        }
    }
}
