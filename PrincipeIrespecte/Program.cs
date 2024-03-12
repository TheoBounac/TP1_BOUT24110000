using System;

// Interface pour afficher les informations du livre
public interface IDisplayable
{
    void DisplayBookInfo();
}

// Interface pour emprunter un livre
public interface IBorrowable
{
    void BorrowBook();
}

// Interface pour retourner un livre
public interface IReturnable
{
    void ReturnBook();
}

// Implémentation des interfaces spécifiques
public class Library : IDisplayable, IBorrowable, IReturnable
{
    public void DisplayBookInfo()
    {
        Console.WriteLine("Affichage des informations du livre");
    }

    public void BorrowBook()
    {
        Console.WriteLine("Emprunt d'un livre");
    }

    public void ReturnBook()
    {
        Console.WriteLine("Retour d'un livre");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Créez une instance de la bibliothèque
        IDisplayable library = new Library();

        // Utilisez les méthodes de la bibliothèque
        library.DisplayBookInfo();
    }
}
