using Microsoft.AspNetCore.Mvc;
using MascotasApi.Modelos;
using System.Collections.Generic;
using System.Linq;
namespace Mascotas.Controladores
{
    [ApiController]
    [Route("api/[controller]")]
    public class RazasDePerrosController : ControllerBase
    {
        private static readonly List<RazaDePerro> Razas = new List<RazaDePerro>
        {
            new RazaDePerro { Id = 1, Nombre = "Labrador Retriever", Descripcion = "Perro amigable y extrovertido.", ImagenUrl = "https://www.vidavetcare.com/wp-content/uploads/sites/234/2022/04/labrador-retriever-dog-breed-info.jpeg" },
            new RazaDePerro { Id = 2, Nombre = "Pastor Alemán", Descripcion = "Perro inteligente y versátil.", ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/94/Cane_da_pastore_tedesco_adulto.jpg/320px-Cane_da_pastore_tedesco_adulto.jpg" },
            new RazaDePerro { Id = 3, Nombre = "Golden Retriever", Descripcion = "Perro leal y confiable.", ImagenUrl = "https://pamipe.com/wp-content/uploads/2022/09/Golden-Retriever-3-800x780.png" },
            new RazaDePerro { Id = 4, Nombre = "Bulldog Inglés", Descripcion = "Perro calmado y amigable, con una apariencia robusta.", ImagenUrl = "https://www.dondemiveterinario.com/wp-content/uploads/2020/05/perro-bulldog-ingles.jpg" },
            new RazaDePerro { Id = 5, Nombre = "Beagle", Descripcion = "Perro curioso y enérgico, conocido por su gran olfato.", ImagenUrl = "https://www.clarin.com/2021/11/10/kEygKZXLi_720x0__1.jpg" },
            new RazaDePerro { Id = 6, Nombre = "Poodle", Descripcion = "Perro inteligente y elegante, conocido por su pelaje rizado.", ImagenUrl = "https://s3.amazonaws.com/cdn-origin-etr.akc.org/wp-content/uploads/2023/02/09141023/Diana-the-Poodle.jpg" },
            new RazaDePerro { Id = 7, Nombre = "Chihuahua", Descripcion = "Perro pequeño pero valiente, con una gran personalidad.", ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/39/Chihuahuas-_Holly%2C_Nina%2C_Doralice.jpg/800px-Chihuahuas-_Holly%2C_Nina%2C_Doralice.jpg" },
            new RazaDePerro { Id = 8, Nombre = "Rottweiler", Descripcion = "Perro fuerte y protector, conocido por su lealtad.", ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fb/02_I_Exposici%C3%B3n_Monogr%C3%A1fica_Club_Rottweiler_de_Espa%C3%B1a_-_Santa_Brigida_-_Gran_Canaria.jpg/640px-02_I_Exposici%C3%B3n_Monogr%C3%A1fica_Club_Rottweiler_de_Espa%C3%B1a_-_Santa_Brigida_-_Gran_Canaria.jpg" },
            new RazaDePerro { Id = 9, Nombre = "Shih Tzu", Descripcion = "Perro pequeño y afectuoso, ideal para compañía.", ImagenUrl = "https://www.hundeo.com/wp-content/uploads/2019/03/Shih-Tzu-Profil.jpg" },
            new RazaDePerro { Id = 10, Nombre = "Dálmata", Descripcion = "Perro activo y amigable, conocido por sus manchas distintivas.", ImagenUrl = "https://smylepets.com/wp-content/uploads/2021/04/Da%CC%81lmata.png" },
            new RazaDePerro { Id = 11, Nombre = "Boxer", Descripcion = "Perro enérgico y juguetón, con una naturaleza protectora.", ImagenUrl = "https://biodog.es/wp-content/uploads/2013/05/boxer.jpg" },
            new RazaDePerro { Id = 12, Nombre = "Doberman", Descripcion = "Perro leal y valiente, conocido por su elegancia y fuerza.", ImagenUrl = "https://www.mascotas.com/uploads/Upload_62471c9715b67_01042022.jpeg" },
            new RazaDePerro { Id = 13, Nombre = "Husky Siberiano", Descripcion = "Perro resistente y activo, con un pelaje grueso y ojos llamativos.", ImagenUrl = "https://www.purina.es/sites/default/files/styles/ttt_image_510/public/2024-02/sitesdefaultfilesstylessquare_medium_440x440public2022-09Siberian20Husky.jpg" },
            new RazaDePerro { Id = 14, Nombre = "Bulldog Francés", Descripcion = "Perro pequeño y robusto, con una personalidad encantadora.", ImagenUrl = "https://www.zooplus.es/magazine/wp-content/uploads/2019/06/franz%C3%B6sische-bulldogge-1024x683.jpg" },
            new RazaDePerro { Id = 15, Nombre = "Cocker Spaniel", Descripcion = "Perro alegre y afectuoso, con un pelaje sedoso y orejas largas.", ImagenUrl = "https://media-be.chewy.com/wp-content/uploads/2021/05/05180433/Cocker-Spaniel_FeaturedImage-1024x615.jpg" },
            new RazaDePerro { Id = 16, Nombre = "San Bernardo", Descripcion = "Perro grande y gentil, conocido por su historia de rescate en los Alpes.", ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/d/d1/Rey_nieve.jpg" },
            new RazaDePerro { Id = 17, Nombre = "Akita Inu", Descripcion = "Perro leal y valiente, con una fuerte presencia y carácter independiente.", ImagenUrl = "https://www.akc.org/wp-content/uploads/2020/11/Japanese-Akitainu-standing-in-the-forest.jpg" },
            new RazaDePerro { Id = 18, Nombre = "Schnauzer", Descripcion = "Perro enérgico y leal, con un pelaje distintivo y cejas pobladas.", ImagenUrl = "https://perro.shop/wp-content/uploads/schnauzer_gigante_1.jpg" },
        };


        [HttpGet]
        public ActionResult<IEnumerable<RazaDePerro>> GetRazas()
        {
            return Ok(Razas);
        }

        [HttpGet("{id}")]
        public ActionResult<RazaDePerro> GetRazaPorId(int id)
        {
            var raza = Razas.FirstOrDefault(r => r.Id == id);
            if (raza == null)
            {
                return NotFound();
            }
            return Ok(raza);
        }

        [HttpPost]
        public ActionResult<RazaDePerro> CrearRaza(RazaDePerro nuevaRaza)
        {
            nuevaRaza.Id = Razas.Max(r => r.Id) + 1;
            Razas.Add(nuevaRaza);
            return CreatedAtAction(nameof(GetRazaPorId), new { id = nuevaRaza.Id }, nuevaRaza);
        }

        [HttpPut("{id}")]
        public ActionResult ActualizarRaza(int id, RazaDePerro razaActualizada)
        {
            var raza = Razas.FirstOrDefault(r => r.Id == id);
            if (raza == null)
            {
                return NotFound();
            }
            raza.Nombre = razaActualizada.Nombre;
            raza.Descripcion = razaActualizada.Descripcion;
            raza.ImagenUrl = razaActualizada.ImagenUrl;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult EliminarRaza(int id)
        {
            var raza = Razas.FirstOrDefault(r => r.Id == id);
            if (raza == null)
            {
                return NotFound();
            }
            Razas.Remove(raza);
            return NoContent();
        }
    }
}
