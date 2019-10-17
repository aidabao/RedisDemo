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
        // 属性注入
        public RedisDemo.Dal.IDal.ITempEvaluationDal tempEvaluationDal { get; set; }
        public IList<TempEvaluation> GetList()
        {
            //TempEvaluationDal td = new TempEvaluationDal();
            var tempEvaluationList = tempEvaluationDal.GetList();
            return tempEvaluationList;
        }
    }
}
