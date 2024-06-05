using Demo_Interface.Interfaces;
using Demo_Interface.Models;

Personne p = new Personne()
{
    Nom = "Petit nuage",
    Prenom = "qui vole haut dessus des montagnes",
    Age = 13

};


if(p.Age < 12)
{
    ILouveteau louveteau = p;

    louveteau.FaireUneRando();
    louveteau.MonterUnAbri();

}
else
{
    IScout scout = p;

    scout.FaireUneRando();
    scout.MonterUnAbri();
    scout.FaireUnFeu();
    scout.PreparerLeRepas();
}
