﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaVorazes.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto>options) : base(options)
        {

        }

        public DbSet<Pacotes> Pacotes { get; set; }

    }
}
