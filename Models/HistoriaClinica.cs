using System;
using System.Collections.Generic;

namespace Dent.Models;

public partial class HistoriaClinica
{
    public int Id { get; set; }

    public int? IdPaciente { get; set; }

    public int? IdPracticaRealizada { get; set; }

    public string? Observaciones { get; set; }

    public int? IdOdontograma { get; set; }
}
