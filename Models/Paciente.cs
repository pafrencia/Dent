﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Dent.Models;

public partial class Paciente
{
    public int Id { get; set; }

    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public string Domicilio { get; set; }

    public int Celular { get; set; }

    public DateTime FechaDeNacimiento { get; set; }

    public DateTime FechaDeAlta { get; set; }

    public string ObraSocial { get; set; }

    public string NumeroAfiliado { get; set; }

    public string PlanDeObraSocial { get; set; }

    public string Titular { get; set; }

    public string Observaciones { get; set; }
}
