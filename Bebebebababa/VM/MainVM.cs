using ConsoleApp47;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bebebebababa.VM
{
    public class MainVM : BaseVM
    {
        MySqlDB161 db = new MySqlDB161();

        private List<Mob> _mobs;
        public List<Mob> Mobs
        {
            get => _mobs;
            set
            {
                _mobs = value;
            }
        }

        private List<Abillity> _abillities;
        public List<Abillity> Abillities
        {
            get => _abillities;
            set
            {
                _abillities = value;
            }
        }
        private Mob _selectedMob;

        public Mob SelectedMob
        {
            get => _selectedMob; 
            set 
            { 
                _selectedMob = value; 
            }
        }


        public CommandVM<Mob> SelectMob { get; set; }

        public MainVM()
        {
            Mobs = MysqlTools.SimpleSelectFromTable<Mob>();
            //Abillities = MysqlTools.SimpleSelectFromTable<Abillity>();

            SelectMob = new CommandVM<Mob>(s =>
            {
                if (s != null)
                {
                    SelectedMob = s;
                    MessageBox.Show($"Selected Mob - {SelectedMob}");
                }
            });
        }
    }
}
