namespace Dent.Models
{
    public class AgregarPracticas
    {

        public void CargarPractica()
        {
            var prueba = new Practica1();
            prueba.Practica = "nueva Practica";
            prueba.Precio = 123;
            using (DbDentistaContext db = new DbDentistaContext())
            {
                db.Practicas.Add(prueba);
                db.SaveChanges();
            }
        }
    }
}
