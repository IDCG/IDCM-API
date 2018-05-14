using System;
using System.Collections.Generic;
using System.Text;

namespace IDCM.ApiTest.Models.InputModels
{
    public class WithdrawinfoInput : InputDto
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
        /// 提币申请ID
        /// </summary>
        public string WithdrawID { set; get; }
    }
}
