using System;
using System.Collections.Generic;
using System.Text;

namespace IDCM.ApiTest.Models.InputModels
{
    public class GetOrderInfoInput : InputDto
    {
        string symbol;
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

        public string OrderID { set; get; }
    }
}
