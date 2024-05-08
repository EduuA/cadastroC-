using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atv_2_westn
{
    public class avaliacao
    {
        public string Nome
            {get;set;}
        public Aluno Aluno
            {get;set;}=new Aluno();
        public string Serie
            {get;set;}
        public Professor Professor
            {get;set;}=new Professor();
        public Disciplina Disciplina
            {get;set;}=new Disciplina();
        public string SerieAluno
            {get;set;}
        public double Nota
            {get;set;}
        
        public avaliacao(string nome, string aluno, string serie, string serieAluno, string matricula, string professor, string titulo, string disciplina, string ch, double nota){       
            this.Nome=nome;
            
            Aluno.Nome=aluno;
            Aluno.Serie=serieAluno;
            Aluno.Matricula=matricula;

            Professor.Nome=professor;
            Professor.Titulo=titulo;

            Disciplina.Nome=disciplina;
            Disciplina.CargaHoraria=ch;

            this.Nota=nota;
            this.Serie=serie;
        }

    }
}