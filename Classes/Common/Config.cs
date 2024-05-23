using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr29savichev.Classes.Common
{
    public class Config
    {
        public static string ConnectionConfig = "server=127.0.0.1;uid=root;database=pcClub";
        public static MySqlServerVersion Version = new MySqlServerVersion(new Version(8, 0, 11));
    }
}
