namespace Readit.Dominio.Opcoes
{
    public record BancoDeDadosOpcoes(string ConnectionString)
    {
        public string ConnectionString { get; } = ConnectionString;
    }
}
