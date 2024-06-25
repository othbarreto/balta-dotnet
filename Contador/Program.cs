// See https://aka.ms/new-console-template for more information

Start(50);

static void Start(int time){

  int currentTime = 0;

  while (currentTime != time){

    Console.Clear();
    currentTime++;
    Console.Write(currentTime);
    Thread.Sleep(1000);
  }
};