using System;
using System.Collections.Generic;

namespace VRCPS.Models
{
    public class BasicDataSet
    {
        public int ID { get; set; }
        public string CreatorId { get; set; }
        public string WorldId { get; set; }
        public string AssociatedId { get; set; }
        public string ObjectId { get; set; }
        public string ObjectData { get; set; }
    }
}