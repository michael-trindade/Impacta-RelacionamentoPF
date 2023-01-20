namespace Escola.Models
{
    public class Turma
    {
        public int TurmaId { get; set; }
        public string TurmaNome { get; set; }
        public int CH { get; set; }
        public ICollection<Aluno> Alunos { get; set; }
    }
}
