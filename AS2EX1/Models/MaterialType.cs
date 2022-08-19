using System;
using System.Collections.Generic;

#nullable disable

namespace AS2EX1.Models
{
    public partial class MaterialType
    {
        public int MaterialTypeId { get; set; }
        public string MaterialTypeCode { get; set; }
        public string MaterialTypeName { get; set; }
        public byte MaterialGroupId { get; set; }
        public bool IsDetail { get; set; }
    }
}
