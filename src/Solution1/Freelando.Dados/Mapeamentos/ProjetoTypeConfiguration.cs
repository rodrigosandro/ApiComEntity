﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Freelando.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelando.Dados.Mapeamentos
{
    public class ProjetoTypeConfiguration : IEntityTypeConfiguration<Projeto>
    {
        public void Configure(EntityTypeBuilder<Projeto> entity)
        {
            entity.ToTable("TB_Projetos");

            entity.HasKey(e => e.Id).HasName("PK_Projeto");
            entity.Property(e => e.Id).HasColumnName("Id_Projeto");
            
            entity.Property(e => e.Descricao)
                .HasColumnType("nvarchar(200)")
                .HasColumnName("DS_Projeto");

            entity.Property(e => e.Status)
                .HasConversion(fromObj => fromObj.ToString(), 
                               fromDb  => (StatusProjeto)Enum.Parse(typeof(StatusProjeto),fromDb));
        }
    }
}
