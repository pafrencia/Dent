using Dent.Pages;

namespace Dent.Models
{
    public class AgregarPracticas
    {

        public void CargarPractica(string Practica, int Precio)
        {
            var prueba = new Practica1();
            prueba.Practica = Practica;
            prueba.Precio = Precio;
            using (DbDentistaContext db = new DbDentistaContext())
            {
                db.Practicas.Add(prueba);
                db.SaveChanges();
            }
        }

    }
}
