namespace Readit.Infraestrutura.Entidades
{
    public class HistoricoSenha(int id, Guid idUsuario, string senha, DateTime dataCriacao, Usuario usuario)
    {
        public int Id { get; set; } = id;
        public Guid IdUsuario { get; set; } = idUsuario;
        public string Senha { get; set; } = senha;
        public DateTime DataCriacao { get; set; } = dataCriacao;

        public virtual Usuario Usuario { get; set; } = usuario;
    }
}
