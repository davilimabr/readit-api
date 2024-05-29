namespace Readit.Infraestrutura.Entidades
{
    public class Livro
        (Guid id,
        string nome,
        string autor,
        byte[] capa,
        DateTime dataPublicacao,
        string sinopse,
        int quantidadePaginas,
        string editora,
        int qauntidadeCurtidas,
        ICollection<Avaliacao> avaliacaos,
        ICollection<CurtidaLivro> curtidas,
        ICollection<ListasLivros> listas)
    {
        public Guid Id { get; set; } = id;
        public string Nome { get; set; } = nome;
        public string Autor { get; set; } = autor;
        public byte[] Capa { get; set; } = capa;
        public DateTime DataPublicacao { get; set; } = dataPublicacao;
        public string Sinopse { get; set; } = sinopse;
        public int QuantidadePaginas { get; set; } = quantidadePaginas;
        public string Editora { get; set; } = editora;
        public int QauntidadeCurtidas { get; set; } = qauntidadeCurtidas;

        public virtual ICollection<Avaliacao> Avaliacaos { get; set; } = avaliacaos;
        public virtual ICollection<CurtidaLivro> Curtidas { get; set; } = curtidas;
        public virtual ICollection<ListasLivros> Listas { get; set; } = listas;
    }
}
