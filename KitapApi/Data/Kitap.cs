using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitapApi.Data
{
    public class Kitap
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int Yil { get; set; }
        public string Yazar { get; set; }
    }
}
