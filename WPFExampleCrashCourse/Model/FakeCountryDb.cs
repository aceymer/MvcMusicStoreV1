using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreWPF.Model
{
    public class FakeCountryDb
    {
        public List<Country> countries;

        public FakeCountryDb() {
            countries = new List<Country>();
            countries.Add(new Country { Id = 1, Name = "Denmark", Info = "We like beer"});
            countries.Add(new Country { Id = 2, Name = "Rusia", Info = "We like Vodka" });
            countries.Add(new Country { Id = 2, Name = "Germany", Info = "We like Schnitzel" });
        }

        public List<Country> GetCountries(){
            return countries;
        }
    }
}
