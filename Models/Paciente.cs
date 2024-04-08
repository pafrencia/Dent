using System;
using System.Collections.Generic;

namespace Dent.Models;

public partial class Paciente
{
    public int Id { get; set; }

    public int IdOdontograma { get; set; }

    public int IdOdontogramaNiño { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Domicilio { get; set; }

    public string? Celular { get; set; }

    public DateTime FechaDeNacimiento { get; set; }

    public DateTime FechaDeAlta { get; set; }

    public string? ObraSocial { get; set; }

    public string? NumeroAfiliado { get; set; }

    public string? PlanDeObraSocial { get; set; }

    public string? Titular { get; set; }

    public string? Observaciones { get; set; }

    public string? Dni { get; set; }

    
}
