using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IDCM.WebsocketConsle.Models
{
    public class CancelOrderEvent : BaseEvent
    {
        public CancelOrder Parameters { set; get; }
    }

    public class CancelOrder
    {
        public string ApiKey { set; get; }
        public string Sign { set; get; }
        public string Symbol { set; get; }
        public string OrderID { set; get; }
        /// <summary>
        /// 定单类型 0、buy  1、sell
        /// </summary>
        public TradeSide Side { set; get; }
    }
    /// <summary>
    /// 交易方向
    /// </summary>
    public enum TradeSide
    {
        /// <summary>
        /// 买入
        /// </summary>
        [Description("买入")]
        BUY,
        /// <summary>
        /// 卖出
        /// </summary>
        [Description("卖出")]
        SELL
    }
}
