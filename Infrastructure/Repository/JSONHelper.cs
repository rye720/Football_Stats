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
        /// <summary>
        /// Requires valid Player JSON file @ URL
        /// </summary>
        /// <param name="jsonUrl"></param>
        /// <returns>Page content (should be valid json)</returns>
        public string GetPlayerJSONFromURL(string jsonUrl)
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(jsonUrl);
                return json;
            }
        }

    }
}
