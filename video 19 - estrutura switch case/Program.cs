/*
    Console.WriteLine("Informe a classe do funcionário (a, b ou c)");
    string cla = Console.ReadLine()!;

    Console.WriteLine("Informe salário");
    double sal = double.Parse(Console.ReadLine()!);

    double nsal = 0;

    switch(cla) {
        case "a":
            nsal = sal + (sal * 0.10);
            break; 

        case "b":
            nsal = sal + (sal * 0.15);
            break; 

        case "c":
            nsal = sal + (sal * 0.20);
            break;

        default:
            Console.WriteLine("Classe indisponivel");
            break;
    }

    Console.WriteLine("Novo salário " + nsal);


//----------DESAFIO 1-----

    Console.WriteLine("Insira o 1º número");
    int n1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Insira o 2º número");
    int n2 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Insira o operador");
    string oper = Console.ReadLine()!;
    int res = 0;

    switch (oper) {
        case "+":
            res = n1 + n2;  
            break;
        case "-":
            res = n1 - n2;  
            break;    
        case "/":
            res = n1 / n2;  
            break;
        case "*":
            res = n1 * n2;  
            break;
        default:
            Console.WriteLine("Operador incorreto, tente estes = *, /, - ou +");
            break;
    }

    Console.WriteLine(res);


//---------------DESAFIO 2-------

    Console.WriteLine("Insira a 1º nota");
    int n1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Insira a 2º nota");
    int n2 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Insira a 3º nota");
    int n3 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Insira a 4º nota");
    int n4 = int.Parse(Console.ReadLine()!);

    int media = (n1 + n2 + n3 + n4) / 4;

    switch(media) {
        case 0:
            Console.WriteLine("Tu é uma batata?");
            break;
        case 1:
            Console.WriteLine("Reprovadaço");
            break;
        case 2:
            Console.WriteLine("Reprovado, estude mais");
            break;
        case 3:
            Console.WriteLine("Reprovado");
            break;
        case 4:
            Console.WriteLine("Recuperação precisa de 8");
            break;
        case 5:
            Console.WriteLine("Recuperação precisa de 7");
            break;
        case 6:
            Console.WriteLine("Recuperação precisa de 6");
            break;
        case 7:
            Console.WriteLine("Por pouco");
            break;
        case 8:
            Console.WriteLine("Aprovado");
            break;
        case 9:
            Console.WriteLine("Parabéns");
            break;
        case 10:
            Console.WriteLine("Excelente");
            break;
    }
    
*/