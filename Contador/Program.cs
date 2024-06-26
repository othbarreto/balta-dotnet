

using System.ComponentModel.Design;

Menu();


static void Menu(){
  
  Console.Clear();
  Console.WriteLine("S - Segundos => 1s = 1 segundo");
  Console.WriteLine("M - Minutos => 1m = 1 minuto");
  Console.WriteLine("0 - Sair");
  Console.WriteLine("Quanto tempo deseja contar ?");

  string data = Console.ReadLine().ToLower();
  char type = char.Parse(data.Substring(data.Length-1, 1));
  int time = int.Parse(data.Substring(0, data.Length-1));
  int multiplier = 1;

  if(type == 'm')
    multiplier = 60;

  if(data == "0")
    System.Environment.Exit(0);

  PreStart(time * multiplier);  
}

static void PreStart(int time){
  Console.Clear();
  Console.WriteLine("Preparar...");
  Thread.Sleep(1000);
  Console.Clear();
  Console.WriteLine("Apontar...");
  Thread.Sleep(1000);
  Console.Clear();
  Console.WriteLine("Vai...");
  Thread.Sleep(1000);

  Start(time);
}

static void Start(int time){

  int currentTime = 0;

  while (currentTime != time){

    Console.Clear();
    currentTime++;
    Console.Write(currentTime);
    Thread.Sleep(1000);
  }

  Console.Clear();
  Console.WriteLine("O Contador foi finalizado");
  Thread.Sleep(2500);
  Menu();
}