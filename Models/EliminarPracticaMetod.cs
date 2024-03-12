using Dent.Pages;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace Dent.Models

{

    public class EliminarPracticaMetod
    {
        private List<Practica1> ListaDePracticas = new List<Practica1>();
        [Inject]
        private DbDentistaContext DbContext { get; set; }
        public void Eliminarla(int practicaId)
        {
            ListaDePracticas = DbContext.Practicas.ToList();
            var practica = DbContext.Practicas.Find(practicaId);
            if (practica != null)
            {
                using (DbDentistaContext db = new DbDentistaContext())
                {
                    db.Practicas.Remove(practica);
                    db.SaveChanges();
                }
            }

        }
    }
}
