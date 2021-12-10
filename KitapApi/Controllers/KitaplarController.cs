using KitapApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitapApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KitaplarController : ControllerBase
    {
        private readonly KitaplarDbContext _db;

        public KitaplarController(KitaplarDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IEnumerable<Kitap> GetKitaplar()
        {
            return _db.Kitaplar.ToList();
        }

        [HttpGet("{id}")]
        public Kitap GetKitap(int id)
        {
            return _db.Kitaplar.Find(id);
        }
    }
}
