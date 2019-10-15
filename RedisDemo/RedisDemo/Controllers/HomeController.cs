using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RedisDemo.Common;

namespace RedisDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public string SetStr(string key,string value)
        {
            string result = "";
            try
            {
                DoRedisString rs = new DoRedisString();
                bool isTrue = rs.Set(key, value,DateTime.Now.AddMinutes(2));
                result = isTrue ? "success" : "error";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }  
            return result;
        }
        public string GetStr(string key)
        {
            string result = "";
            try
            {
                DoRedisString rs = new DoRedisString();
                result = rs.Get(key);
                if (result == null)
                {
                    SetStr(key, "tom");
                }
                result = rs.Get(key);
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
        [HttpPost]
        public string SetList(string key, string value)
        {
            string result = "success";
            try
            {
                DoRedisList rl = new DoRedisList();
                rl.Add(key, value, DateTime.Now.AddMinutes(2));          
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
        public string GetList(string key)
        {
            string result = "";
            try
            {
                DoRedisList rl = new DoRedisList();
                List<string> liStr = rl.Get(key);
                if (liStr == null)
                {
                    SetList(key, "tom");
                }
                liStr = rl.Get(key);
                result = string.Join(",", liStr);
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
        [HttpPost]
        public string SetSet(string key, string value)
        {
            string result = "success";
            try
            {
                DoRedisSet rs = new DoRedisSet();
                rs.Add(key, value);
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
        public string GetSet(string key)
        {
            string result = "";
            try
            {
                DoRedisSet rs = new DoRedisSet();
                var hashset = rs.GetAllItemsFromSet(key);
                if (hashset != null)
                {
                    result = string.Join(",", hashset);
                }
                else
                {
                    result = "无数据";
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }
        [HttpPost]
        public string SetZSet(string key, string value)
        {
            string result = "success";
            try
            {
                DoRedisZSet rz = new DoRedisZSet();
                rz.AddItemToSortedSet(key, value);
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
        public string GetZSet(string key)
        {
            string result = "";
            try
            {
                DoRedisZSet rz = new DoRedisZSet();
                var zSetStr = rz.GetAllItemsFromSortedSet(key);
                if (zSetStr.Count>0)
                {
                    result = string.Join(",", zSetStr);
                }
                else
                {
                    result = "无数据";
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
        [HttpPost]
        public string SetHash(string hashId, string key, string value)
        {
            string result = "success";
            try
            {
                DoRedisHash rh = new DoRedisHash();
                rh.SetEntryInHash(hashId, key, value);
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
        public string GetHash(string hashId)
        {
            string result = "";
            try
            {
                DoRedisHash rh = new DoRedisHash();
                var dic = rh.GetAllEntriesFromHash(hashId);
                if (dic != null)
                {
                    result = Newtonsoft.Json.JsonConvert.SerializeObject(dic);
                }
                else
                {
                    result = "无数据";
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
    }
}