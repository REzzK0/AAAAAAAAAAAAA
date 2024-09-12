using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebebebababa
{
    [MysqlTable("Mobs")]
    public class Mob:BaseModel
    {
        [MysqlColumn("MobID")]
        public int MobID { get; set; }
        [MysqlColumn("Name")]
        public string Name { get; set; }
        [MysqlColumn("Health")]
        public int Health { get; set; }
        [MysqlColumn("Damage")]
        public int Damage { get; set; }
        [MysqlColumn("SpawnLocation")]
        public string SpawnLocation { get; set; }

        public override string ToString()
        {
            return $"{Name} {Health} {Damage} {SpawnLocation}";
        }
    }
}
