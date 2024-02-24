using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dent.Models;

public partial class Practica
{
    [Key]
    public int Id { get; set; }

    public string? Practica1 { get; set; }

    public int? Precio { get; set; }
}
