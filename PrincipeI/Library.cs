using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using System;

// Interface regroupant toutes les méthodes de la bibliothèque
public interface ILibrary
{
    void DisplayBookInfo();
    void BorrowBook();
    void ReturnBook();
}

// Implémentation de l'interface ILibrary
public class Library : ILibrary
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
        ILibrary library = new Library();

        // Utilisez les méthodes de la bibliothèque
        library.DisplayBookInfo();
        library.BorrowBook();
        library.ReturnBook();
    }
}
