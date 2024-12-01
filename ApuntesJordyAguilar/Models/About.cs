using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApuntesJordyAguilar.Models
{
    public class About
    {
        public string Title { get; set; } = "Notes Jordy Aguilar";
        public string Version { get; set; } = AppInfo.VersionString;
        public string Message { get; set; } = "Hola, soy Jordy Aguilar, soy de Zaruma, tengo 20 años, me gusta el futbol y el anime :)";
        public string MoreInfoUrl { get; set; } = "https://aka.ms/maui";
    }
}
