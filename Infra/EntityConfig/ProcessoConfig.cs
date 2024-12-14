using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig;

public class ProcessoConfig : IEntityTypeConfiguration<Processo>
{
    public void Configure(EntityTypeBuilder<Processo> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).ValueGeneratedOnAdd();
        builder.Property(c => c.Nome);
        builder.Property(c => c.Npu).HasMaxLength(25);
        builder.HasKey(c => c.DataCadastro);
        builder.Property(c => c.DataVisualizacao);
        builder.Property(c => c.Uf).HasMaxLength(2);
        builder.Property(c => c.Municipio);
    }
}