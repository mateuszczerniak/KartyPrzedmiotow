using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace KartyPrzedmiotow2.Models
{
    public class Uzytkownik : IdentityUser
    {
        public Uzytkownik()
        {
            Tytuly = new List<Tytul>();
            Programy = new List<Program>();
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<Uzytkownik> manager)
        {
            // Element authenticationType musi pasować do elementu zdefiniowanego w elemencie CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Dodaj tutaj niestandardowe oświadczenia użytkownika
            return userIdentity;
        }
        
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public virtual ICollection<Program> Programy { get; set; }
        
        public virtual ICollection<Tytul> Tytuly { get; set; }
        public virtual ICollection<UzytkownikWydzialy> Wydzialy { get; set; }
    }
}