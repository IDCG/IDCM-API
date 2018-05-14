using System;
using System.Collections.Generic;
using System.Text;

namespace IDCM.WebsocketConsle.Models
{
    public class LoginEvent : BaseEvent
    {
        public LoginInfo parameters { set; get; }
    }

    public class LoginInfo
    {
        public string ApiKey { set; get; }

        public string Sign { set; get; }
    }
}
