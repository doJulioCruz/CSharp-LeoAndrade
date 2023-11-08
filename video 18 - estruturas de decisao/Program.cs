/*  Console.WriteLine("Insira o primeiro número ");
    int n1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Insira o segundo número ");
    int n2 = int.Parse(Console.ReadLine()!);

    if(n1 > n2) {
        Console.Write("O maior número é: ");
        Console.WriteLine(n1);
    } else {
        Console.Write("O maior número é: ");
        Console.WriteLine(n2);
    }

    //--------------------

    Console.Write("Insira a primeira nota: ");
    int n1 = int.Parse(Console.ReadLine()!);
    Console.Write("Insira a segunda nota: ");
    int n2 = int.Parse(Console.ReadLine()!);
    Console.Write("Insira a terceira nota: ");
    int n3 = int.Parse(Console.ReadLine()!);
    Console.Write("Insira a quarta nota: ");
    int n4 = int.Parse(Console.ReadLine()!);

    int media = (n1 + n2 + n3 + n4) / 4;

    if (media > 7) {
    Console.WriteLine("Aprovado!");
    }else {
    Console.WriteLine("Reprovado!");
    }
    
    //--------------------

    //DESAFIO 1

    Console.Write("Insira o valor do saque:");
    double n1 = int.Parse(Console.ReadLine()!);
    double saldo = 1000 - n1;

    if (n1 >= 1000) {
       Console.WriteLine("Saldo insuficiente! "); 
    }   else {
        Console.Write("Seu novo saldo é de: ");
        Console.Write(saldo);
    }
    
    //-------------DESAFIO 2---

    Console.Write("Insira a primeira nota: ");
    int n1 = int.Parse(Console.ReadLine()!);
    Console.Write("Insira a segunda nota: ");
    int n2 = int.Parse(Console.ReadLine()!);
    Console.Write("Insira a terceira nota: ");
    int n3 = int.Parse(Console.ReadLine()!);
    Console.Write("Insira a quarta nota: ");
    int n4 = int.Parse(Console.ReadLine()!);

    int media = (n1 + n2 + n3 + n4) / 4;

    if ( media >= 7) {
        Console.WriteLine("APROVADO");
    }else {
        if (media < 4) {
            Console.WriteLine("REPROVADO!");
        }else {
            Console.WriteLine("RECUPERAÇÃO!");
        }
    }

    //------DESAFIO 3-------
    
    Console.Write("Insira um numero: ");
    int n1 = int.Parse(Console.ReadLine()!);
        
    if ((n1 % 5) == 0) {
        Console.WriteLine("É divisivel!");
    }else {
        Console.WriteLine("Não é");
    }

    //--------DESAFIO 4-------

    Console.Write("Insira o primeiro número: ");
    int n1 = int.Parse(Console.ReadLine()!);
    Console.Write("Insira o segundo número: ");
    int n2 = int.Parse(Console.ReadLine()!);
    Console.Write("Insira o terceiro número: ");
    int n3 = int.Parse(Console.ReadLine()!);

    if ((n1 < n2 && n1 < n3)) {
        Console.WriteLine("O número " + n1 + " é o menor.");
    }else {
        if (n2 < n3) {
            Console.WriteLine("O número " + n2 + " é o menor!");
        }else {
            Console.WriteLine("O número " + n3 + " é o menor!");
        }
    }


//-------DESAFIO 5----
    Console.WriteLine("Insira o valor do salário");
    double n1 = double.Parse(Console.ReadLine()!);

    if (n1 <= 500) {
        Console.WriteLine("O novo salário é: ");
        Console.Write((n1 * 1.10));
    }else {
        Console.WriteLine("Sem aumento...");
    }
*/