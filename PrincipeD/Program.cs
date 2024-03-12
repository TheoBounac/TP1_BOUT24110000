using System;

// Classe haute niveau
public class HighLevelModule
{
    // Violation du DIP : dépend directement de la classe bas niveau
    private LowLevelModule lowLevelModule = new LowLevelModule();

    // Méthode effectuant une tâche à l'aide de la classe bas niveau
    public void DoSomething()
    {
        lowLevelModule.PerformTask();
    }
}

// Classe bas niveau
public class LowLevelModule
{
    // Méthode effectuant une tâche spécifique
    public void PerformTask()
    {
        Console.WriteLine("Performing task...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Utilisation de la classe haute niveau
        HighLevelModule highLevelModule = new HighLevelModule();
        highLevelModule.DoSomething();
    }
}
