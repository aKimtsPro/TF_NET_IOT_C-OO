using Demo_Exceptions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Exceptions.Interfaces
{
    public interface IUtilisateurService
    {
        Dictionary<string, Utilisateur> GetAll();
        Utilisateur GetByEmail(string email);
        void Create(Utilisateur utilisateur);
        void Delete(string Email);
    }
}
