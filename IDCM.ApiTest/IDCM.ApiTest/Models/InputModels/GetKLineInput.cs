using System;
using System.Collections.Generic;
using System.Text;

namespace IDCM.ApiTest.Models.InputModels
{
    public class GetKLineInput : InputDto
    {
        string symbol;
        /// <summary>
        /// 交易对
        /// </summary>
        public string Symbol
        {
            set
            {
                symbol = value;
            }
            get
            {
                return symbol.Replace("-", "/");
            }
        }
        /// <summary>
        /// \3min : 3分钟 \3day : 3日\2hour : 2小时\4hour : 4小时\6hour : 6小时\12hour : 12小时
        /// 1min : 1分钟\5min : 5分钟\15min : 15分钟\30min : 30分钟 \1day : 1日\1week : 1周\1hour : 1小时
        /// </summary>
        public string @Type { set; get; }
        /// <summary>
        /// 指定获取数据的条数
        /// </summary>
        public int Size { set; get; }
        /// <summary>
        /// 时间戳，返回该时间戳以后的数据(例如1417536000000)
        /// </summary>
        public long Since { set; get; }
    }
}
