using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Superheroes.Models
{
    public class Superhero
    {
        public int id { get; set; }
        public string superName { get; set; }
        public string alterEgoName { get; set; }
        public string primarySuperpower { get; set; }
        public string secondarySuperpower { get; set; }
        public string catchphrase { get; set; }
    }
}