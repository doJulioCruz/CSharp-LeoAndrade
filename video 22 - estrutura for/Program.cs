/*
    for(int contador = 0; contador <= 10; contador++) {
        Console.WriteLine(contador);
    }

    // {} = PLACEHOLDER
    //O 1º {} é preenchido com o 1º valor depois da virgula


    for(int c = 0; c <= 10; c++) {
    Console.WriteLine("7 x {0} = {1}",c, 7 * c);
    }

    Console.WriteLine("Insira um número");
    int numb = int.Parse(Console.ReadLine()!);


    for(int c = 0; c <= 10; c++) {
    Console.WriteLine("{2} x {0} = {1}",c, numb * c, numb);
    }

//----------DESAFIO 1--------

    Console.WriteLine("Insira um número");
    int numb = int.Parse(Console.ReadLine()!);


    for(int c = 0; c <= numb; c++) {
    Console.WriteLine(c);
    }

//---------------DESAFIO 2--------

    
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