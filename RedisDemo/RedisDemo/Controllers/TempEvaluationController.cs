using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RedisDemo.Bll.IBll;
using RedisDemo.Bll.Bll;
using RedisDemo.Common.Domain;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace RedisDemo.Controllers
{
    public class TempEvaluationController:Controller
    {
        public ITempEvaluationBll tempEvaluationBll { get; set; }
        public ActionResult List()
        {           
            return View();
        }
        public string GetData(int page,int limit)
        {
            string result = "";
            var li = tempEvaluationBll.GetList();
            var newli = li.Skip((page - 1) * limit).Take(limit).ToList();
            ResBaseObj<IList<TempEvaluation>> ro = new ResBaseObj<IList<TempEvaluation>>();
            ro.code = 200;
            ro.msg = "成功";
            ro.data = newli;
            ro.count = li.Count;
            result = JsonConvert.SerializeObject(ro);
            return result;
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}