Console.Write("Digite o primeiro número: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual operação deseja realizar? \n" +
                  "1 - Adição \n" +
                  "2 - Subtração \n" +
                  "3 - Multiplicação \n" +
                  "4 - Divisão");
string operador = Console.ReadLine();

Console.Write("Digite o segundo número: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double resultado = 0;
if (operador == "1") {
    resultado = num1 + num2;
}
else if (operador == "2") {
    resultado = num1 - num2;
}
else if (operador == "3") {
    resultado = num1 * num2;
}
else if (operador == "4") {
    if (num2 != 0) {
        resultado = num1 / num2;
    }
    else {
        Console.WriteLine("Erro: Divisão por zero.");
        return;
    }
}
else {
    Console.WriteLine("Operador inválido.");
    return;
}

Console.WriteLine("O resultado é: " + resultado);