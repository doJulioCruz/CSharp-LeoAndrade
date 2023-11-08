/*
    int resultado = 0;
    Console.WriteLine("informe um número diferente de 0");
    int numero = int.Parse(Console.ReadLine()!);

    while(numero != 0) {
        resultado = resultado + numero;

        Console.WriteLine("Resultado parcial é: " + resultado);

        Console.WriteLine("informe um novo número:");
        numero = int.Parse(Console.ReadLine()!);
    }

    Console.WriteLine("Resultado final: " + resultado);

//----------------EX 2-------

    Console.Write("Insira um numero maior que 100: ");
    int numero = int.Parse(Console.ReadLine()!);

    while(numero < 100){
        Console.WriteLine(numero + "é um número invalido, digite um número maior que 100!");
        numero = int.Parse(Console.ReadLine()!);
    }

    Console.WriteLine("Certo, " + numero + " é um número válido!");

//-----------------DESAFIO 1----------------


    Console.Write("DESAFIANTE: Informe um número de 0 a 100: ");
    int desafiante = int.Parse(Console.ReadLine()!);

    while(desafiante > 100){
        Console.WriteLine("Por favor, um número menor que 100");
        desafiante = int.Parse(Console.ReadLine()!);
    }
    Console.Clear();

    Console.Write("DESAFIADO: Faça o palpite de um número entre 0 a 100: ");
    int desafiado = int.Parse(Console.ReadLine()!);

    while(desafiado > 100){
        Console.WriteLine("Por favor, um número menor que 100");
        desafiado = int.Parse(Console.ReadLine()!);
    }

    while(desafiante != desafiado){
        
        Console.WriteLine("Palpite errado, tente de novo! ");
        desafiado = int.Parse(Console.ReadLine()!);
    }

    Console.Write("Parabéns, " + desafiado + " é o número correto!");
    
*/

    