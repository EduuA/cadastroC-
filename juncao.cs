using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atv_2_westn
{
    public class juncao
    {
    List<avaliacao> avaliacoes=new List<avaliacao>();

    //CADASTRAR
    public void Cadastrar(){
        string nome, aluno, serieAv, serieAluno, matricula, professor, titulo, disciplina, ch; 
        double nota;

        System.Console.WriteLine("\nCadastro de avaliação:\n");

        System.Console.Write("Escreva o título da avaliação: ");
        nome=Console.ReadLine();
        System.Console.Write("Informe a série: ");
        serieAv=Console.ReadLine();

        System.Console.Write("\nAluno:\n\n");
        System.Console.Write("Escreva o nome: ");
        aluno=Console.ReadLine();
        System.Console.Write("Informe a série: ");
        serieAluno=Console.ReadLine();
        System.Console.Write("Escreva o número de matrícula: ");
        matricula=Console.ReadLine();

        System.Console.Write("\nProfessor:\n\n");
        System.Console.Write("Escreva o nome: ");
        professor=Console.ReadLine();
        System.Console.Write("Informe o título: ");
        titulo=Console.ReadLine();

        System.Console.Write("\nDisciplina:\n\n");
        System.Console.Write("Escreva o nome: ");
        disciplina=Console.ReadLine();
        System.Console.Write("Informe a carga horária: ");
        ch=Console.ReadLine();
        System.Console.Write("\nNota:\n\n");
        System.Console.Write("Informe a nota tirada: ");
        nota=Double.Parse(Console.ReadLine());
            
        if(serieAv.Equals(serieAluno)){
            avaliacao avaliacao_obj=new avaliacao(nome,aluno,serieAv, serieAluno, matricula,professor, titulo, disciplina,ch,nota);
            
            avaliacoes.Add(avaliacao_obj);
        }else{			
            System.Console.WriteLine("\n\nErro: Série da avaliação não condiz com a série do aluno");
        }
    }

    //LISTAR
    public void Listar(){
        System.Console.WriteLine("\n\nAvaliações::::\n");

        foreach(avaliacao i in avaliacoes){
            System.Console.WriteLine("Avaliação: "+i.Nome+" ");
            System.Console.WriteLine("Disciplina: "+i.Disciplina.Nome+"// Carga Horária: "+i.Disciplina.CargaHoraria);	
            System.Console.WriteLine("Professor: "+i.Professor.Nome+"// Título: "+i.Professor.Titulo);		
            System.Console.WriteLine("Aluno: "+i.Aluno.Nome+"// Série: "+i.Aluno.Serie+"// N° de Matrícula: "+i.Aluno.Matricula);
            System.Console.WriteLine("Nota: "+i.Nota);
        }
    }
    
    //MENU
    public void Menu(){
        int i=1;

        while(i!=0){
            System.Console.WriteLine("Menu\n");
            System.Console.WriteLine("1.Cadastrar Avaliação\n2.Listar Avaliações\n0.Sair");
            i=Int32.Parse(Console.ReadLine());
            
            switch(i){
                case 1:
                    Cadastrar();
                    break;
                case 2:
                    Listar();
                    break;
                case 0:
                    break;
                default:
                    System.Console.WriteLine("Erro: Informe uma opção válida");
                    break;

            }
        }
    }
    }
}