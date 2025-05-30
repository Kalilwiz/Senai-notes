﻿using System;
using System.Collections.Generic;

namespace Senai_notes.Models;

public partial class Usuario
{
    public int UserId { get; set; }

    public string Nome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public DateTime? DataCriacao { get; set; }

    public virtual ICollection<Nota> Nota { get; set; } = new List<Nota>();
}
