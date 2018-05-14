using System;
using System.Collections.Generic;
using System.Text;

namespace IDCM.WebsocketConsle.Models
{
    public class GetUserinfoEvent : BaseEvent
    {
        public Userinfo Parameters { set; get; }
    }

    public class Userinfo
    {
        public string ApiKey { set; get; }
        public string Sign { set; get; }
    }
}
