using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisDemo.Common.Domain
{
    public class TempEvaluation
    {
        public virtual int Id { get; set; }
        public virtual int EvalHouseId { get; set; }
        public virtual string EvalOrg { get; set; }
        public virtual string CommunityName { get; set; }
        public virtual string CommunityAddress { get; set; }
        public virtual double Price { get; set; }
        public virtual double Evaluation { get; set; }

    }
}
