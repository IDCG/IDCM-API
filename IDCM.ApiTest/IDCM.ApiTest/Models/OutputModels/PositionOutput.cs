using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDCM.ApiTest.Models.OutputModels
{
    public class PositionOutput
    {
        [JsonProperty("timestamp")]
        public long Timestamp { set; get; }
        /// <summary>
        /// 买一价
        /// </summary>
        [JsonProperty("buy")]
        public decimal Buy { set; get; }
        /// <summary>
        /// 最高价
        /// </summary>
        [JsonProperty("high")]
        public decimal High { set; get; }
        /// <summary>
        /// 最新成交价
        /// </summary>
        [JsonProperty("last")]
        public decimal Last { set; get; }
        /// <summary>
        /// 最低价
        /// </summary>
        [JsonProperty("low")]
        public decimal Low { set; get; }
        /// <summary>
        /// 卖一价
        /// </summary>
        [JsonProperty("sell")]
        public decimal Sell { set; get; }
        /// <summary>
        /// 成交量(最近的24小时)
        /// </summary>
        [JsonProperty("vol")]
        public decimal Vol { set; get; }
    }
}
