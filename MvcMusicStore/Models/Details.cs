using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Detail
    {
        private int p;

        public Detail(int id)
        {
            // TODO: Complete member initialization
            this.Id = id;
        }
        public int Id{get; set;}

        public string Name { get; set; }
    }
}