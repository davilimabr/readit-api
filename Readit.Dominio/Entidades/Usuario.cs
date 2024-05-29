namespace Readit.Infraestrutura.Entidades
{
    public class Usuario
        (Guid id,
        string nome,
        string email,
        DateTime dataNascimento,
        ICollection<HistoricoSenha> senhas,
        ICollection<Avaliacao> avaliacoes,
        ICollection<Lista> listas,
        ICollection<Curtida> curtidas)
    {
        public Guid Id { get; set; } = id;
        public string Nome { get; set; } = nome;
        public string Email { get; set; } = email;
        public DateTime DataNascimento { get; set; } = dataNascimento;

        public virtual ICollection<HistoricoSenha> Senhas { get; set; } = senhas;
        public virtual ICollection<Avaliacao> Avaliacoes { get; set; } = avaliacoes;
        public virtual ICollection<Lista> Listas { get; set; } = listas;
        public virtual ICollection<Curtida> Curtidas { get; set; } = curtidas;
    }
}
