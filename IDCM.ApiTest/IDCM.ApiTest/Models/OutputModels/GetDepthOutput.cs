using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDCM.ApiTest.Models.OutputModels
{
    public class GetDepthOutput
    {
        /// <summary>
        /// 卖方深度
        /// </summary>
        [JsonProperty("asks")]
        public OrderBookItemOutput[] Asks { set; get; }
        /// <summary>
        /// 买方深度
        /// </summary>
        [JsonProperty("bids")]
        public OrderBookItemOutput[] Bids { set; get; }
    }

    public class OrderBookItemOutput
    {
        string symbol;
        /// <summary>
        /// 交易对 btc_usd   ltc_usd    eth_usd    etc_usd    bch_usd
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol
        {
            set
            {
                symbol = value;
            }
            get
            {
                return symbol.Replace("/", "-");
            }
        }
        /// <summary>
        /// 价格
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { set; get; }
        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { set; get; }
    }
}
