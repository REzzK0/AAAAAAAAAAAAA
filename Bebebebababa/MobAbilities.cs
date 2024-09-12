using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebebebababa
{
    [MysqlTable("MobAbilities")]
    internal class MobAbilities
    {   
        [MysqlColumn("MobAbilityID")]
        public int MobAbilityID { get; set; }


        [MysqlRelation ("Mobs", "MobID")]
        public List <Mob> Mobs { get; set; }

        [MysqlRelation("Abilities", "AbilityID")]
        public List<Abillity> Abilities { get; set; }
    }
}
