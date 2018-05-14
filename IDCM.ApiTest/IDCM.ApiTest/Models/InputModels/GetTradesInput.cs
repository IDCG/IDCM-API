using System;
using System.Collections.Generic;
using System.Text;

namespace IDCM.ApiTest.Models.InputModels
{
    public class GetTradesInput : InputDto
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
        /// 时间戳,运回该时间戳之后的交易记录 最多返回500条数据
        /// </summary>
        public long Since { set; get; }
    }
}
