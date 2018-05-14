using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDCM.ApiTest.Models.OutputModels
{
    public class GetUserInfoOutput
    {
        /// <summary>
        /// 币种
        /// </summary>
        [JsonProperty("code")]
        public string code { set; get; }
        /// <summary>
        /// 可用
        /// </summary>
        [JsonProperty("free")]
        public decimal free { set; get; }
        /// <summary>
        /// 冻结
        /// </summary>
        [JsonProperty("freezed")]
        public decimal freezed { set; get; }
    }
}
