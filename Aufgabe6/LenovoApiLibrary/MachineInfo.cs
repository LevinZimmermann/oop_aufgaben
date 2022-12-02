using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenovoApiLibrary
{
    public class MachineInfo
    {
        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("group")]
        public string ProductGroup { get; set; }

        [JsonProperty("serial")]
        public string Serial { get; set; }

        [JsonProperty("shipDate")]
        public string ShipDate { get; set; }

        [JsonProperty("productImage")]
        public string ProductImageURL { get; set; }

        [JsonProperty("currentWarranty")]
        public Warranty CurrentWarranty { get; set; }

        public BaseWarranties BaseWarrantyList { get; set; }

        public UpgradeWarranties UpgradeWarrantyList { get; set; }

        public ContractWarranties ContractWarrantyList { get; set; }

        public string JsonData { get; set; }
    }
}
