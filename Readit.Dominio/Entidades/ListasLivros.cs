namespace Readit.Infraestrutura.Entidades
{
    public class ListasLivros(Guid idLista, Guid idLivro, DateTime dataAdicao, Livro livro, Lista lista)
    {
        public Guid IdLista { get; set; } = idLista;
        public Guid IdLivro { get; set; } = idLivro;
        public DateTime DataAdicao { get; set; } = dataAdicao;

        public virtual Livro Livro { get; set; } = livro;
        public virtual Lista Lista { get; set; } = lista;
    }
}
