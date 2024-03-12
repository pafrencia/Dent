namespace Dent.Models
{
    public class AgregarPracticaRealizada
    {
        public void CargarPractica(string Practica, int Precio, string PacienteAtendido)
        {
            var prueba = new PracticasRealizada();
            prueba.Practica = Practica;
            prueba.Precio = Precio;
            prueba.Paciente = PacienteAtendido;
            using (DbDentistaContext db = new DbDentistaContext())
            {
                db.PracticasRealizadas.Add(prueba);
                db.SaveChanges();
            }
        }
    }
}

