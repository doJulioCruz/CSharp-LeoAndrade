/*
//--------ex 1----------

    int resultado = 0;
    int numero = 0;
do {
        numero = int.Parse(Console.ReadLine()!);

        resultado = resultado + numero;
        Console.WriteLine("Resultado " + resultado);
    }while(numero != 0);
 

//---------ex 2-------

    int numero;

    do {
        Console.WriteLine("Informe um número maior que 100!");
        numero = int.Parse(Console.ReadLine()!);

    }while(numero < 100);

    Console.WriteLine("Número correto!");


//---------DESAFIO 1----------------

    int desafiante;
    int desafiado;

        Console.WriteLine("DESAFIANTE: Insira um número até 100");
        desafiante = int.Parse(Console.ReadLine()!);
        Console.Clear();

        Console.WriteLine("DESAFIADO: Insira um número até 100");
        desafiado = int.Parse(Console.ReadLine()!);

    do{
        
        Console.WriteLine("DESAFIADO: palpite errado, tente novamente!");
        desafiado = int.Parse(Console.ReadLine()!);

    } while (desafiante != desafiado);
    Console.WriteLine("Parabéns, número correto!");

//--------DESAFIO 1 RESOLUÇÃO DO LEO----

    Console.WriteLine("JOGADOR DESAFIANTE");
    Console.WriteLine("Informe um número de 0 a 9");
    int numero = int.Parse(Console.ReadLine()!);

    Console.Clear();

    int x = 0;
    string msg = "JOGADOR DESAFIADO";

    do
    { 
        Console.WriteLine(msg);
        Console.WriteLine("Tente acertar o número de 0 a 9");
        x = int.Parse(Console.ReadLine()!);
        
        
        
        msg = "Errou, tente novamente!";
        
    } while (x != numero);

  Console.WriteLine("Parabéns, tu acertou!");

// do video 22
        Console.WriteLine("Insira um Número Final");
        int numb = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Insira um Número Multiplicador");
        int mult = int.Parse(Console.ReadLine()!);

    while(numb < mult){
        Console.WriteLine("O Número Final é menor que o multiplicador, Insira outro!");
        numb = int.Parse(Console.ReadLine()!);
        Console.WriteLine("O multiplicador deve ser menor que o Número Final");
        mult = int.Parse(Console.ReadLine()!);
    }

    Console.Clear();
    
    for(int c = 0; c <= numb; c = c + mult) {
    Console.WriteLine(c);
    }
*/

    Console.WriteLine("um nº de 0 a 10");
    int numero = int.Parse(Console.ReadLine()!);

    Console.WriteLine("chute um nº de 0 a 10");
    int chute = int.Parse(Console.ReadLine()!);

    int tentativas = 0;

   
    if(tentativas < 3){
        
        while (chute != numero){
            tentativas++;
            Console.Write("tente de novo: ");
            chute = int.Parse(Console.ReadLine()!);
            
            Console.WriteLine("tentativas: " + tentativas);
            
        }
        Console.Write("parabens");
    }else{
        Console.Write("acabo papai");
    }