namespace Readit.Infraestrutura.Entidades
{
    public class Curtida(int id, Guid idUsuario, DateTime dataCurtida, Usuario usuario, ICollection<CurtidaAvaliacao> avaliacoes, ICollection<CurtidaLivro> livros)
    {
        public int Id { get; set; } = id;
        public Guid IdUsuario { get; set; } = idUsuario;
        public DateTime DataCurtida { get; set; } = dataCurtida;

        public virtual Usuario Usuario { get; set; } = usuario;
        public virtual ICollection<CurtidaAvaliacao> Avaliacoes { get; set; } = avaliacoes;
        public virtual ICollection<CurtidaLivro> Livros { get; set; } = livros;
    }
}
