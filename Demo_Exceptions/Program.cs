using Demo_Exceptions.Exceptions;
using Demo_Exceptions.Models;
using Demo_Exceptions.Services;

UtilisateurService service = new UtilisateurService();

try
{
    service.Create(new Utilisateur("Doe", "John", "jd@mail.com", 30));
    service.Create(new Utilisateur("Doe", "Jane", "janed@mail.com", 26));

    Dictionary<string, Utilisateur> utilisateurs = service.GetAll();
    Console.WriteLine("--------------GET ALL--------------");
    foreach (KeyValuePair<string, Utilisateur> user in utilisateurs)
    {
        Console.WriteLine($"{user.Value.Prenom} {user.Value.Nom}");
    }
    Console.WriteLine("--------------GET BY MAIL--------------");
    Utilisateur utilisateur = service.GetByEmail("jd@mail.com");
    Console.WriteLine($"{utilisateur.Prenom} {utilisateur.Nom}");

    service.Delete("jd@mail.com");
}
catch (KeyNotFoundException ex)
{
    Console.WriteLine("L'email n'existe pas dans la liste");
}
catch (PasEncoreEnPlace ex)
{
    Console.WriteLine(ex.GetType());
    Console.WriteLine(ex.Message);
}
catch (NotImplementedException ex)
{
    Console.WriteLine("Cette methode n'est pas encore disponible");
}
catch (Exception ex)
{
    Console.WriteLine(ex.GetType());
    Console.WriteLine(ex.Message);
}