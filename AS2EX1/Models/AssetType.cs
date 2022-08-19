using System;
using System.Collections.Generic;

#nullable disable

namespace AS2EX1.Models
{
    public partial class AssetType
    {
        public int AssetTypeId { get; set; }
        public string AssetTypeCode { get; set; }
        public string AssetTypeName { get; set; }
        public byte AssetTypeGroupId { get; set; }
        public bool IsDetail { get; set; }
    }
}
