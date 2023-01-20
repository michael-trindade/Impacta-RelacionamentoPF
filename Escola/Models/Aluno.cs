namespace Escola.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public string NomeAluno { get; set; }
        
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }
    }
}
