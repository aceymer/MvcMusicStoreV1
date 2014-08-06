using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models.FakeDB
{
    public class FakeDB
    {
        private Dictionary<int, Detail> Details = new Dictionary<int, Detail>();

        public FakeDB() {
            Details.Add(1, new Detail(1) { Name="TheName1" });
            Details.Add(2, new Detail(2) { Name = "TheName2" });
            Details.Add(3, new Detail(3) { Name = "TheName3" });
            Details.Add(4, new Detail(4) { Name = "TheName4" });
            Details.Add(5, new Detail(5) { Name = "TheName5" });
            Details.Add(6, new Detail(6) { Name = "TheName6" });
        }

        public Detail GetDetail(int detailId) { 
            return Details.ContainsKey(detailId) ? Details[detailId] : null;
        }
    }
}