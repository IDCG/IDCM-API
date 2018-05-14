using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace IDCM.ApiTest.Extensions
{
    public static class Ext
    {
        public static string ToJson(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
