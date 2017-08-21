using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class JSONHelper
    {

        public string GetPlayerJSONFromURL(string url)
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(url);
                return json;
            }
        }

    }
}
