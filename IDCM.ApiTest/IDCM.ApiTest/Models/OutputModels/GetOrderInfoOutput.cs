using IDCM.ApiTest.Models.InputModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDCM.ApiTest.Models.OutputModels
{
    public class GetOrderInfoOutput
    {
        /// <summary>
        /// 定单ID
        /// </summary>
        [JsonProperty("orderid")]
        public string OrderID
        {
            set; get;
        }

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
        /// 委托价格
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { set; get; }
        /// <summary>
        /// 平均成交价
        /// </summary>
        [JsonProperty("avgprice")]
        public decimal AvgPrice { set; get; }
        /// <summary>
        /// 交易方向
        /// </summary>
        [JsonProperty("side")]
        public TradeSide Side { set; get; }
        /// <summary>
        /// 定单类型
        /// </summary>
        [JsonProperty("type")]
        public OrderType Type { set; get; }
        /// <summary>
        /// 委托时间
        /// </summary>
        [JsonProperty("timestamp")]
        public long Timestamp { set; get; }
        /// <summary>
        /// 委托数量
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { set; get; }
        /// <summary>
        /// 成交数量
        /// </summary>
        [JsonProperty("executedamount")]
        public decimal ExecutedAmount { set; get; }
        /// <summary>
        /// 定单状态
        /// </summary>
        [JsonProperty("status")]
        public OrderStatus Status { set; get; }
    }
}
