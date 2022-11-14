using System;

class Aula12{
    static void Main(){

        int senha_cad, senha2_cad, senha_log, operador;
        string nome_cad, nome_log;
        bool senha_igual, nome, senha, tentativa;

        tentativa = senha = nome = senha_igual = false;
        senha_cad = senha2_cad = senha_log = 0;

        Console.WriteLine("[ÁREA DE CADASTRO]\n");

        Console.Write("NOME:");
        nome_cad = Console.ReadLine();

        Console.Write("SENHA:");
        senha_cad = int.Parse(Console.ReadLine());

        while (senha_igual == false){
            Console.Write("REPITA A SENHA:");
            senha2_cad = int.Parse(Console.ReadLine());

            if (senha_cad == senha2_cad){
                senha_igual = true;
            }
            else
            {
                Console.WriteLine("SENHA DIFERENTE... TENTE NOVAMENTE");
            }
        }

        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("[ÁREA DE LOGIN]\n");
    

        while(nome == false){

            Console.Write("NOME:");
            nome_log = Console.ReadLine();

            if (nome_cad == nome_log){
                    nome = true;
            }
            else
            {
                Console.WriteLine("NOME INVÁLIDO... TENTE NOVAMENTE");
            }
        }

        for (int j = 0; j < 5; j++)
        {
            operador = 5 - j;
            Console.Write("\nSENHA:");
            senha_log = int.Parse(Console.ReadLine());

            if (senha_log != senha2_cad){
                Console.WriteLine("A SENHA ESTÁ INCORRETA! TENTE NOVAMENTE");
                Console.WriteLine("VOCÊ TEM "+  operador +" TENTATIVA(S)!\n");
                tentativa = false;
            }
            else {
                j = 6;
                tentativa = true;
            }
        }

        if (tentativa == true){
            Console.WriteLine("LOGIN APROVADO");
        }
        else {
            Console.WriteLine("LOGIN INVÁLIDO");
        }

        Console.ReadKey();
    }
}