using System;
using System.Collections.Generic;

namespace Dent.Models;

public partial class PracticasRealizada
{
    public int Id { get; set; }

    public string Paciente { get; set; }

    public string Practica { get; set; }

    public string ObraSocial { get; set; }

    public string Odontologo { get; set; }

    public DateTime Fecha { get; set; }

    public int Precio { get; set; }

    public int IdPaciente { get; set; }

    public string Observaciones { get; set; }
}
