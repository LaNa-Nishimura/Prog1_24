// OPERADORES

int a = 3;
int b = a++; // ++ é um acumulador (a+1)
WriteLine($"a é {a}, b é {b}"); // entretanto o acúmulo vai ocorrer depois da atribuição, pois o ++ está ao lado direito de a

int c = 3;
int d = ++c;
WriteLine($"c é {c}, d é {d}"); // neste caso o ++ está ao lado esquerdo de c, portanto o acúmulo ocorre antes da atribuição

// COMBINANDO OPERADORES DE ATRIBUIÇÃO

int p = 6;
p =+ 3; // equivalente a p = p + 3
p -= 3; // equivalente a p = p - 3
p *= 3; // equivalente a p = p * 3
p /= 3; // equivalente a p = p / 3

// OPERADORES LÓGICOS

bool b_A = true;
bool b_B = false;
WriteLine();
WriteLine($"AND  | b_A   | b_B  |");
WriteLine($"b_A  | {b_A & b_A, -5} | {b_A & b_B, -5}"); // -5 = ocupar o espaço de 5 caracteres
WriteLine($"b_B  | {b_B & b_A, -5} | {b_B & b_B, -5}");
WriteLine();

WriteLine($"OR   | b_A   | b_B  |");
WriteLine($"b_A  | {b_A | b_A, -5} | {b_A | b_B, -5}");
WriteLine($"b_B  | {b_B | b_A, -5} | {b_B | b_B, -5}");
WriteLine();

WriteLine($"XOR  | b_A   | b_B  |");
WriteLine($"b_A  | {b_A ^ b_A, -5} | {b_A ^ b_B, -5}");
WriteLine($"b_B  | {b_B ^ b_A, -5} | {b_B ^ b_B, -5}");