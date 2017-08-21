using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public sealed class Player
    {
        public int RowID { get; set; }

        public string birthdate { get; set; }

        public string college { get; set; }
      
        public string first_name { get; set; }
       
        public string full_name { get; set; }
       
        public string gsis_id { get; set; }
       
        public string gsis_name { get; set; }
       
        public string height { get; set; }
       
        public string last_name { get; set; }
        
        public string profile_id { get; set; }
        
        public string profile_url { get; set; }
        
        public string weight { get; set; }
        
        public string years_pro { get; set; }
    }
}


