using IDCM.ApiTest.Models.OutputModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDCM.ApiTest.Models.InputModels
{
    public class GetHistoryOrderInput : InputDto
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
        /// 查询状态
        /// </summary>
        public OrderStatus Status { set; get; }
        /// <summary>
        /// 当前页数
        /// </summary>
        public int PageIndex { set; get; }
        int pageSize;
        /// <summary>
        /// 每页数据条数，最多不超过200
        /// </summary>
        public int PageSize
        {
            set { pageSize = value; }
            get
            {
                if (pageSize > 200) return 200;
                return pageSize;
            }
        }
    }
}
