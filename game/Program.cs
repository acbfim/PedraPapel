using game;

var jogador = new Jogador();
var jogadorCPU = new Jogador() {Nome = "CPU"};

Console.WriteLine("------ Informe seu nome ----------");

jogador.Nome = Console.ReadLine();

Console.WriteLine("------ Escolha uma jogada ----------");

int jogada = 0;

while (jogada != -1)
{
    Console.WriteLine(" ");
    
    Console.WriteLine($"{nameof(JogadaEnum.PEDRA)} - 1");
    Console.WriteLine($"{nameof(JogadaEnum.PAPEL)} - 2");
    Console.WriteLine($"{nameof(JogadaEnum.TESOURA)} - 3");

    jogada = Convert.ToInt32(Console.ReadLine());
    
    jogador.Jogada = (JogadaEnum)Enum.Parse(typeof(JogadaEnum), jogada.ToString());

    Random random = new Random();

    jogadorCPU.Jogada = (JogadaEnum)Enum.Parse(typeof(JogadaEnum), random.Next(1, 4).ToString());

    Console.Clear();

    

    Console.WriteLine("");
    
    for (int i = 0; i < 10; i++)
    {
        if(i == 0)
            Console.Write("Calculando.");

        Console.Write(".");
        Thread.Sleep(200);
    }

    Console.WriteLine(" ");

    Console.WriteLine("Resultado: ");

    Console.WriteLine(" ");

    Console.WriteLine($"Jogador {jogador.Nome} jogou: " + jogador.Jogada);
    Console.WriteLine($"Jogador {jogadorCPU.Nome} jogou: " + jogadorCPU.Jogada);

    Console.WriteLine(" ");
    var ganhador = JogadaUtil.MostrarGanhador(jogador,jogadorCPU);

    if(ganhador == null)
         Console.WriteLine($"Empate");
    else
        Console.WriteLine($"Ganhador: {ganhador.Nome}");


}
