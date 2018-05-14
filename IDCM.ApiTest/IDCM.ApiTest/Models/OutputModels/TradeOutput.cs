using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDCM.ApiTest.Models.OutputModels
{
    public class TradeOutput
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        [JsonProperty("orderid")]
        public string OrderID { set; get; }
    }
}
