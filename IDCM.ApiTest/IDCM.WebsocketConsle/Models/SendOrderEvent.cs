using System;
using System.Collections.Generic;
using System.Text;

namespace IDCM.WebsocketConsle.Models
{
    public class SendOrderEvent : BaseEvent
    {
        public OrderInfo Parameters { set; get; }
    }

    public class OrderInfo
    {
        public string ApiKey { set; get; }
        public string Sign { set; get; }
        public string Symbol { set; get; }
        public string @Type { set; get; }
        public decimal Price { set; get; }
        public decimal Amount { set; get; }
        /// <summary>
        /// 是否市场价
        /// </summary>
        public bool IsMarket { set; get; }
    }
}
