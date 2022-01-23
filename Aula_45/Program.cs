using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio01();
            Exercicio02();
            Exercicio03();
        }
        static void Exercicio01()
        {
            Retangulo ret = new Retangulo();
            ret.AskInfo();
            Console.WriteLine(ret);

        }
        static void Exercicio02()
        {
            Funcionario fun = new Funcionario();
            fun.AskInfo();
            Console.WriteLine(fun);
            fun.AumentarSalario();
            Console.WriteLine(fun);
        }
        static void Exercicio03()
        {
            Aluno aluno = new Aluno();
            aluno.AskInfo();
            Console.WriteLine(aluno);
        }
    }
}