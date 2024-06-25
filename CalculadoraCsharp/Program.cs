// See https://aka.ms/new-console-template for more information
using System.Reflection;

Menu();

static void Menu(){

  Console.WriteLine("Bem-vindo, vamos calcular!");
  Console.WriteLine("Escolha uma operação:");
  Console.WriteLine("");
  Console.WriteLine("1 - Soma");
  Console.WriteLine("2 - Subtração");
  Console.WriteLine("3 - Multiplicação");
  Console.WriteLine("4 - Divisão");
  Console.WriteLine("5 - Sair");
  Console.WriteLine("");
  short res = short.Parse(Console.ReadLine());

  switch (res){
  case 1: Soma(); break;
  case 2: Subtracao(); break;  
  case 3: Multiplicacao(); break;  
  case 4: Divisao(); break;
  case 5: System.Environment.Exit(0); break;
  default: Menu(); break;
  };

};

static void Soma(){
  Console.Clear();

  Console.WriteLine("Vamos SOMAR valores:");

  Console.WriteLine("Digite o PRIMEIRO valor:");
  float valor1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Digite o SEGUNDO valor:");
  float valor2 = float.Parse(Console.ReadLine());

  float resultado = valor1 + valor2;

  Console.WriteLine($"O resultado da SOMA dos valores é: {resultado} ");
  Console.ReadKey();
  Menu();
};

static void Subtracao(){

  Console.Clear();

  Console.WriteLine("Vamos Subtrair valores:");

  Console.WriteLine("Digite o PRIMEIRO valor:");
  float valor1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Digite o SEGUNDO valor:");
  float valor2 = float.Parse(Console.ReadLine());

  float resultado = valor1 - valor2;

  Console.WriteLine($"O resultado da SOMA dos valores é: {resultado} ");
  Console.ReadKey();
  Menu();
};

static void Multiplicacao(){
  Console.Clear();

  Console.WriteLine("Vamos Multiplicar valores:");

  Console.WriteLine("Digite o PRIMEIRO valor:");
  float valor1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Digite o SEGUNDO valor:");
  float valor2 = float.Parse(Console.ReadLine());

  float resultado = valor1 * valor2;

  Console.WriteLine($"O resultado da SOMA dos valores é: {resultado} ");
  Console.ReadKey();
  Menu();
};

static void Divisao(){
  Console.Clear();

  Console.WriteLine("Vamos DIVIDIR valores:");

  Console.WriteLine("Digite o PRIMEIRO valor:");
  float valor1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Digite o SEGUNDO valor:");
  float valor2 = float.Parse(Console.ReadLine());

  float resultado = valor1 / valor2;

  Console.WriteLine($"O resultado da SOMA dos valores é: {resultado} ");
  Console.ReadKey();
  Menu();
};