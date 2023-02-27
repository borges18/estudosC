// Aprendendo sobre o método "Trim", que faz o corte de espaços das cadeias de caracteres.

string greeting = "            Hello, world!             ";
Console.WriteLine($"[{greeting}]");

// O método "TrimStart", vai fazer o corte apenas no início da cadeia de caracteres.
string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

// Já o "TrimEnd", faz a mesma função do anterior, porém o corte agora é apenas no final.
trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

// Por fim, o método "Trim", faz o corte tanto no início quanto no fim.
trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");