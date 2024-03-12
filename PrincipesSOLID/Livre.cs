using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
public class Livre
{
    public string titre;
    public string auteur;
    public string genre;

    public void DisplayLivreTitre()
    {
        Console.WriteLine("Titre:"+titre.ToString());
    }

    /**A enlever pour respecter le principe S
    public async void SaveLivre()
    {
        await File.WriteAllTextAsync($"./livre-{titre}.json", JsonSerializer.Serialize(this, new
            JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        }));
    }*/
}

public class LivreBaseDeDonnees /**Une deuxieme classe est cree pour respecter le principe S*/
{
    public async void SaveLivre(Livre livre)
    {
        await File.WriteAllTextAsync($"./livre-{livre.titre}.json", JsonSerializer.Serialize(livre, new
            JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        }));
    }
}
