using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmodul10_1302223007.Controllers
{
    [Route("api/[controller]")]
    public class MahasiswaController : Controller
    {
        private static List<Mahasiswa> mhs = new List<Mahasiswa>
        {
            new Mahasiswa("Muhammad Haulul Azkiyaa", "1302223007"),
            new Mahasiswa("Fauzein Mulya Warman", "1302223127"),
            new Mahasiswa("Iksan Oktav Risandy", "1302223042"),
            new Mahasiswa("Muhammad Dias Adani", "1302223134"),
            new Mahasiswa("Muhammad Nur Shodiq", "1302223054")
        };

        // GET: api/values
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mhs;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mhs[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Mahasiswa value)
        {
            mhs.Add(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mhs.RemoveAt(id);
        }
    }
}

