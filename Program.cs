using System;

namespace ModificadoresAcesso
{
    namespace FiapHelloWorld
    {
        public class Curso
        {
            #region atributos
            int Codigo;
            internal string NomeCurso;
            public string NomeInstrutor;
            private int CargaHorario;
            protected int MinimoAlunos;
            protected internal int MaximoAlunos;
            #endregion
            public Curso()
            {
                // Construtor padrão.
            }
            protected internal Curso(string nome, string instrutor)
            {
                this.NomeCurso = nome;
                this.NomeInstrutor = instrutor;
            }
            private Curso(string nome, int minimo, int maximo)
            {
                this.NomeCurso = nome;
                this.MaximoAlunos = maximo;
                this.MinimoAlunos = minimo;
            }
            public void CriarCurso(string nome, string instrutor)
            {
                this.NomeCurso = nome;
                this.NomeInstrutor = instrutor;
            }
            private bool MatricularAluno(string nomeAluno)
            {
                // Verificar a quantidade de alunos
                return true;
            }
            private int ConsultarMaximoAlunos()
            {
                // Retorno o valor do atributo
                return this.MaximoAlunos;
            }
        }
    }
}
