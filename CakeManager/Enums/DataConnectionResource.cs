using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeManager.Enums
{
    public enum DataConnectionResource : Int32
    {
        [StringValue("Server=127.0.0.1;Port=3306;Database=CAKEMANAGER;Uid='root';Pwd =''")]
        GENERICMYSQL = 1,
        [StringValue("Server=127.0.0.1;Port=3306;Database=cakemanager;Uid='root';Pwd=''")]
        LOCALMYQSL = 2,
        [StringValue("Server=127.0.0.1;Port=3306;Database=cakemanagerApi;Uid='root';Pwd=''")]
        LOCALMYQSLAPI = 4,
        [StringValue("http://localhost:60485/api/")]
        LOCALAPI = 3,
    }
}
