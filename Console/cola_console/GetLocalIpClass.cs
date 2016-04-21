
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace cola_console
{
    class GetLocalIpClass
    {
        public string GetLocalIp()
        {
            IPAddress ipAddr =
                Dns.GetHostEntry(Dns.GetHostName()).AddressList[0];//获得当前IP地址
            string ip = ipAddr.MapToIPv4().ToString();
            return ip;
        }
    }
}
