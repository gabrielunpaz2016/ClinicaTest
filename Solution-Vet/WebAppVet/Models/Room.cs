using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class Room : IEntity
    {
       
        public string name { get; set; }
        public string location { get; set;}
        public int Id { get; set; }

        
    }
}