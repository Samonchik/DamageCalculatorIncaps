using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageCalculator
{
    internal class SwordDamage
    {
        public SwordDamage(int startingRoll)
        {
            Roll = startingRoll;
            CalculateDamage();
        }
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

        private int roll;
        private bool flaming;
        private bool magic;
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }
        public bool Flaming
        {
            get { return flaming; }
            set 
            {
                flaming = value;
                CalculateDamage();
            }
        }
        
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }
        public int Damage { get; private set; }

        private void CalculateDamage()
        {
            decimal MagicMultiplier = 1M;
            if (Magic) MagicMultiplier = 1.75M;

            Damage = (int)(Roll * MagicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;
        }
    }
}
