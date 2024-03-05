using System;
using System.Collections.Generic;

namespace Dent.Models;

public partial class Login
{
    public int Id { get; set; }

    public string? Usuario { get; set; }

    public string? Contraseña { get; set; }
}
