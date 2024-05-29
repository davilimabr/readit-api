namespace Readit.Infraestrutura.Entidades
{
    public class CurtidaAvaliacao(int idCurtida, Guid idAvaliacao, Curtida curtida, Avaliacao avaliacao)
    {
        public int IdCurtida { get; set; } = idCurtida;
        public Guid IdAvaliacao { get; set; } = idAvaliacao;

        public virtual Curtida Curtida { get; set; } = curtida;
        public virtual Avaliacao Avaliacao { get; set; } = avaliacao;
    }
}
