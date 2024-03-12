using System;

// Interface représentant le module bas niveau
public interface IModule
{
    void PerformTask();
}

// Classe haute niveau
public class HighLevelModule
{
    // Respect du DIP : dépend d'une abstraction plutôt que d'une implémentation concrète
    private IModule module;

    // Injection de dépendance par le constructeur
    public HighLevelModule(IModule module)
    {
        this.module = module;
    }

    // Méthode effectuant une tâche à l'aide de l'abstraction
    public void DoSomething()
    {
        module.PerformTask();
    }
}

// Classe bas niveau implémentant l'interface
public class LowLevelModule : IModule
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
        // Utilisation de l'abstraction pour injecter la dépendance
        IModule lowLevelModule = new LowLevelModule();
        HighLevelModule highLevelModule = new HighLevelModule(lowLevelModule);
        highLevelModule.DoSomething();
    }
}
