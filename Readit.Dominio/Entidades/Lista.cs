namespace Readit.Infraestrutura.Entidades
{
    public class Lista(Guid id, Guid idUsuario, string nome, bool publica, DateTime dataCriacao, ICollection<ListasLivros> livros, Usuario usuario)
    {
        public Guid Id { get; set; } = id;
        public Guid IdUsuario { get; set; } = idUsuario;
        public string Nome { get; set; } = nome;
        public bool Publica { get; set; } = publica;
        public DateTime DataCriacao { get; set; } = dataCriacao;

        public virtual ICollection<ListasLivros> Livros { get; set; } = livros;
        public virtual Usuario Usuario { get; set; } = usuario;
    }
}
