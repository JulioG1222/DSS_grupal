﻿using System;
using System.Collections.Generic;

namespace DSS_Scoring.Models;

public partial class LluviaIdeas
{
    public int Id { get; set; }

    public int? IdProyecto { get; set; }

    public int? IdUsuario { get; set; }

    public string Etapa { get; set; } = null!;

    public string Idea { get; set; } = null!;

    public virtual Proyecto? IdProyectoNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}