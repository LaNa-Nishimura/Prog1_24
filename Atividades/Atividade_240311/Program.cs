using System;

Console.WriteLine("De qual número será a tabuada: ");
double tabuada = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("De qual operação será a tabuada: \n" +
                  "1 - Adição \n" +
                  "2 - Subtração \n" +
                  "3 - Multiplicação \n" +
                  "4 - Divisão");
string operador = Console.ReadLine();

double resultado = 0;

WriteLine();
WriteLine($"Tabuada de {tabuada}");

for (int i = 1; i <= 9; i++) {
    if (operador == "1") {
        resultado = tabuada + i;
        WriteLine($"{tabuada} + {i} = {resultado}");
    }

    else if (operador == "2") {
        resultado = tabuada - i;
        WriteLine($"{tabuada} - {i} = {resultado}");
    }
    
    else if (operador == "3") {
        resultado = tabuada * i;
        WriteLine($"{tabuada} * {i} = {resultado}");
    }

    else if (operador == "4") {
        resultado = tabuada / i;
        WriteLine($"{tabuada} / {i} = {resultado}");
    }

    else {
        WriteLine("Opção Inválida.");
    }
}