using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Freelando.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelando.Dados.Mapeamentos
{
    public class ContratoTypeConfiguration : IEntityTypeConfiguration<Contrato>
    {
        public void Configure(EntityTypeBuilder<Contrato> entity)
        {
            entity.ToTable("TB_Contratos");
            entity.HasKey(e => e.Id).HasName("PK_Contrato");
            entity.Property(e => e.Id).HasColumnName("Id_Contrato");
            entity.Property(e => e.DataInicio).HasColumnName("Data_Inicio");
            entity.Property(e => e.DataEncerramento).HasColumnName("Data_Encerramento");
        }
    }
}
