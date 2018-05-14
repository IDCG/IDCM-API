using System;
using System.Collections.Generic;
using System.Text;

namespace IDCM.ApiTest.Models.InputModels
{
    public class WithdrawInput : InputDto
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
        /// 钱包地址
        /// </summary>
        public string Address { set; get; }
        /// <summary>
        /// 提币数量 
        /// </summary>
        public decimal Amount { set; get; }
    }
}
