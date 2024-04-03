using System;
using System.Collections.Generic;

namespace Dent.Models;

public partial class Turno
{
    public int Id { get; set; }

    public DateTime DiaMesAño { get; set; }

    public TimeSpan Hora { get; set; }

    public int? IdOdontologo { get; set; }

    public int? IdPaciente { get; set; }

    public string? Observaciones { get; set; }

    public string? Practica { get; set; }
}
