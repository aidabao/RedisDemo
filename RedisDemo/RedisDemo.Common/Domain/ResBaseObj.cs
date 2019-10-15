using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisDemo.Common.Domain
{
    public class ResBaseObj<T>
    {
        public int code{get;set;}
        public string msg{get;set;}
        public int count { get; set; }
        public T data { get; set; }
    }
}
