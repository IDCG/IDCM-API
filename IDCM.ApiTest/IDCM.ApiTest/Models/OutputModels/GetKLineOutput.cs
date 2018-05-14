using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDCM.ApiTest.Models.OutputModels
{
    public class GetKLineOutput
    {
        /// <summary>
        /// 时间戳
        /// </summary>
        [JsonProperty("timestamp")]
        public long TimeStamp { set; get; }
        /// <summary>
        /// 开
        /// </summary>
        [JsonProperty("open")]
        public decimal Open { set; get; }
        /// <summary>
        /// 高
        /// </summary>
        [JsonProperty("high")]
        public decimal High { set; get; }
        /// <summary>
        /// 低
        /// </summary>
        [JsonProperty("low")]
        public decimal Low { set; get; }
        /// <summary>
        /// 收
        /// </summary>
        [JsonProperty("close")]
        public decimal Close { set; get; }
        /// <summary>
        /// 交易量
        /// </summary>
        [JsonProperty("vol")]
        public decimal Vol { set; get; }
    }
}
