using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bebebebababa
{
    [MysqlTable("Abilities")]
    public class Abillity : BaseModel
    {
        [MysqlColumn("AbilityID")]
        public int AbilityID { get; set; }
        [MysqlColumn ("AbilityName")]
        public string AbilityName { get; set; }
        [MysqlColumn ("Description")]
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{AbilityName} {Description} ";
        }
    }
}
