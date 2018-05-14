using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDCM.ApiTest.Models.OutputModels
{
    public class GetTradesOutput
    {
        /// <summary>
        /// 交易时间
        /// </summary>
        [JsonProperty("date")]
        public long Date { set; get; }
        /// <summary>
        /// 交易价格
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { set; get; }
        /// <summary>
        /// 交易数量
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { set; get; }
        /// <summary>
        /// buy/sell
        /// </summary>
        [JsonProperty("side")]
        public string Side { set; get; }
    }
}
