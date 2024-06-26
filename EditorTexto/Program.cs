Menu();

static void Menu(){
  Console.Clear();

  Console.WriteLine("O que vocÊ deseja fazer ?");
  Console.WriteLine("1 - Abrir arquivo"); 
  Console.WriteLine("2 - Criar um arquivo");
  Console.WriteLine("0 - Sair");

  short option = short.Parse(Console.ReadLine());

  switch (option){
    case 0: System.Environment.Exit(0); break;
    case 1: Abrir(); break;
    case 2: Criar(); break;
    default: Menu(); break;

  }

}

static void Abrir(){
  Console.Clear();
  Console.WriteLine("Qual o caminho do arquivo ?");
  string path = Console.ReadLine();

  using (var file = new StreamReader(path)){
    string text = file.ReadToEnd();
    Console.WriteLine(text);

    Console.WriteLine("");
    Console.ReadLine();
    Menu();
  }
}

static void Criar(){
  Console.Clear();
  Console.WriteLine("Digite seu texto abaixo: (ESC para sair)");
  Console.WriteLine("-----------------------------");
  string text = "";

  do{
    text += Console.ReadLine();
    text += Environment.NewLine;
  } while (Console.ReadKey().Key != ConsoleKey.Escape);

  Salvar(text);

}

static void Salvar(string text){
  Console.Clear();
  Console.WriteLine("Qual caminho você deseja salvar o arquivo ? ");
  var path = Console.ReadLine();

  using (var file = new StreamWriter(path)){
    file.Write(text);
  }

  Console.WriteLine($"Arquivo salvo em {path} com sucesso!");
  Console.ReadLine();
  Menu();

}