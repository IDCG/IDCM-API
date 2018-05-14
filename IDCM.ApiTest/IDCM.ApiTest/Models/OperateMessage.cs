using System;
using System.Collections.Generic;
using System.Text;

namespace IDCM.ApiTest.Models
{
    public enum OperateResult
    {
        Success = 1,
        Fail = 0
    }

    public class OperateMessage<T>
    {
        public OperateResult result { get; set; }
        public string code { get; set; }
        public T data { get; set; }
    }
}
