using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.Interfacce
{
    interface IRegCercaAnnunci : ICercaAnnunci
    {

        void segnala();
        void preferisci();
    }
}
