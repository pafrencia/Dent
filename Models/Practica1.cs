using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dent.Models;

public class Practica1
{
    [Key]
    public int Id { get; set; }

    public string? Practica { get; set; }

    public int? Precio { get; set; }
}
