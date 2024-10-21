using Adapter_pattern;

class Program
{
    static void Main(string[] args)
    {
        ComputerGame game = new ComputerGame
        (
            "Counter-Strike 2",
            PegiAgeRating.P16,
            50,
            1024,
            85,
            8,
            4,
            2.66
        );

        PCGame pcGame = new ComputerGameAdapter(game);

        Console.WriteLine($"Название: {pcGame.Title()}");
        Console.WriteLine($"Разрешенный возраст: {pcGame.PegiAllowedAge()}");
        Console.WriteLine($"Это TripleA Игра: {pcGame.isTripleAGame()}");

        Requirements requirements = pcGame.Requirements();
        Console.WriteLine($"Минимальная память GPU: {requirements.getGpuGb()} GB");
        Console.WriteLine($"Нужное дисковое пространство: {requirements.getHDDGb()} GB");
        Console.WriteLine($"Необходимая оперативная память: {requirements.getRAMGb()} GB");
        Console.WriteLine($"Скорость ядра: {requirements.getCpuGhz()} GHz");
        Console.WriteLine($"Необходимое количество ядер: {requirements.getCoresNum()}");
    }
}