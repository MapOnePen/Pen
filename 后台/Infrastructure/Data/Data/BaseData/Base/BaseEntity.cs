using BaseData.Interface;
using System;

namespace BaseData.Base
{
    public partial class BaseEntity:IBaseEntity
    {
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool Deleted { get; set; }
        public bool Enabled { get; set; }
    }
}
