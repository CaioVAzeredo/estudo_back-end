using Atividade1.Modelos;

Aluno aluno = new Aluno("Caio");
aluno.AdicionarNota(new Avaliacao(10));
aluno.AdicionarNota(new Avaliacao(8));
aluno.AdicionarNota(new Avaliacao(7));
aluno.ExibirAluno();