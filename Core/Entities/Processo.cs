namespace Core.Entities;

public class Processo
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Npu { get; set; }
    public DateTime? DataCadastro { get; set; }
    public DateTime? DataVisualizacao { get; set; }
    public string? Uf { get; set; }
    public string? Municipio { get; set; }
}
