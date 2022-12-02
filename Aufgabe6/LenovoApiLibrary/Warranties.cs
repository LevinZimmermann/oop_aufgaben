using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenovoApiLibrary
{
    
    public class BaseWarranties
    {
        [JsonProperty("baseWarranties")]
        public List<Warranty> WarrantyList { get; set; }
    }

    public class UpgradeWarranties
    {
        [JsonProperty("upgradeWarranties")]
        public List<Warranty> WarrantyList { get; set; }
    }

    public class ContractWarranties
    {
        [JsonProperty("contractWarranties")]
        public List<Warranty> WarrantyList { get; set; }
    }
}
