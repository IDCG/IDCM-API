using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IDCM.WebsocketConsle.Models
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
    /// <summary>
    /// 订单类型 0、Market   1、Limit,   2、Stop,   3、TrailingStop,   4、FillOrKill,   5、ExchangeMarket,  6、       ExchangeLimit  7、ExchangeStop   8、ExchangeTrailingStop,   9、ExchangeFillOrKill
    /// </summary>
    public enum OrderType
    {
        /// <summary>
        /// Market
        /// </summary>
        [Description("市场价")]
        Market = 0,
        /// <summary>
        /// Limit
        /// </summary>
        [Description("限价")]
        Limit = 1,
        /// <summary>
        /// Stop
        /// </summary>
        [Description("Stop")]
        Stop = 2,
        /// <summary>
        /// TrailingStop
        /// </summary>
        [Description("TrailingStop")]
        TrailingStop = 3,
        /// <summary>
        /// FillOrKill
        /// </summary>
        [Description("FillOrKill")]
        FillOrKill = 4,
        /// <summary>
        /// ExchangeMarket
        /// </summary>
        [Description("ExchangeMarket")]
        ExchangeMarket = 5,
        /// <summary>
        /// ExchangeLimit
        /// </summary>
        [Description("ExchangeLimit")]
        ExchangeLimit = 6,
        /// <summary>
        /// ExchangeStop
        /// </summary>
        [Description("ExchangeStop")]
        ExchangeStop = 7,
        /// <summary>
        /// ExchangeTrailingStop
        /// </summary>
        [Description("ExchangeTrailingStop")]
        ExchangeTrailingStop = 8,
        /// <summary>
        /// ExchangeFillOrKill
        /// </summary>
        [Description("ExchangeFillOrKill")]
        ExchangeFillOrKill = 9
    }
    /// <summary>
    /// 订单状态
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// 取消交易
        /// </summary> 
        [Description("取消交易")]
        Cancel = -2,
        /// <summary>
        /// 无效
        /// </summary>
        [Description("无效")]
        Invalid = -1,
        /// <summary>
        /// 等待成交
        /// </summary>
        [Description("等待成交")]
        WaitDeal = 0,
        /// <summary>
        /// 部分交易
        /// </summary>
        [Description("部分交易")]
        PartDeal = 1,
        /// <summary>
        /// 全部成交
        /// </summary>
        [Description("全部成交")]
        DealSuccess = 2,
        /// <summary>
        /// 已申报
        /// </summary>
        [Description("已申报")]
        QuoteDeclare = 3,
        #region 后台 需要
        /// <summary>
        /// 暂无数据
        /// </summary>
        [Description("--")]
        Nodata = -99
        #endregion


    }
}
