using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Bem vindo a seletiva pro time de cs");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("voce gostaria de participar? sim ou nao?");
            Console.WriteLine("-----------------------------------------");
                string resposta = Console.ReadLine();                            
                    if(resposta == "sim"){
                        Console.WriteLine("Otimo, entao vamos analizar seu perfil.");
                        Console.WriteLine("Por favor, insira seu boletim");
                            int notas = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira suas faltas");
                            int faltas = int.Parse(Console.ReadLine());
                                if(notas>=50 && faltas<= 10){
                                    Console.WriteLine("Parabens! Voce foi aprovado");
                                }else{
                                    Console.WriteLine("Infelizmente voce nao possui rendimento escolar suficiente para participar do projeto");
                                }
                    }else{
                        Console.WriteLine("Tudo bem, vou deixar anotado aqui.");
                    }
            Console.ReadLine();
        }
}
