using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCRUD.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
    }
}