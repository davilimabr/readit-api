namespace Readit.Infraestrutura.Entidades
{
    public class CurtidaLivro(int idCurtida, Guid idLivro, Curtida curtida, Livro livro)
    {
        public int IdCurtida { get; set; } = idCurtida;
        public Guid IdLivro { get; set; } = idLivro;

        public virtual Curtida Curtida { get; set; } = curtida;
        public virtual Livro Livro { get; set; } = livro;
    }
}
