namespace Readit.Infraestrutura.Entidades
{
    public class Avaliacao
        (Guid id,
        Guid idUsuario,
        Guid idLivro,
        string comentario,
        int nota,
        int quantidadeCurtidas,
        string tags,
        DateTime dataAvaliacao,
        DateTime dataTerminoLeitura,
        Usuario usuario,
        Livro livro,
        ICollection<CurtidaAvaliacao> curtidas)
    {
        public Guid Id { get; set; } = id;
        public Guid IdUsuario { get; set; } = idUsuario;
        public Guid IdLivro { get; set; } = idLivro;
        public string Comentario { get; set; } = comentario;
        public int Nota { get; set; } = nota;
        public int QuantidadeCurtidas { get; set; } = quantidadeCurtidas;
        public string Tags { get; set; } = tags;
        public DateTime DataAvaliacao { get; set; } = dataAvaliacao;
        public DateTime DataTerminoLeitura { get; set; } = dataTerminoLeitura;

        public virtual Usuario Usuario { get; set; } = usuario;
        public virtual Livro Livro { get; set; } = livro;
        public virtual ICollection<CurtidaAvaliacao> Curtidas { get; set; } = curtidas;
    }
}
