using IDCM.ApiTest.Models.InputModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IDCM.ApiTest.Models.OutputModels
{
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
    [Serializable]
    public class OrderOutput
    {
        public string ID;
        public string Symbol;
        public string Exchange;
        public decimal Price;
        public decimal AvgExecutionPrice;
        public TradeSide Side;
        public OrderType Type;
        public DateTime Timestamp;
        public bool IsLive;
        public bool IsCancelled;
        public bool IsHidden;
        public bool WasForced;
        public decimal OriginalAmount;
        public decimal RemainingAmount;
        public decimal ExecutedAmount;
        public string Message;
        public OrderStatus Status;
    }
}
