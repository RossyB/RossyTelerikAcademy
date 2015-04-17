﻿using ArmyOfCreatures.Logic.Specialties;
using ArmyOfCreatures.Logic.Battles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ArmyOfCreatures.Extended.Specialties
{
    public class DoubleDamage : Specialty
    {
        private int rounds;

        public DoubleDamage(int rounds)
        {
            if (rounds <= 0 && rounds > 10)
            {
                throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be greater than 0 and less ot equal than 10!");
            }

            this.rounds = rounds;
        }

        public override decimal ChangeDamageWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender, decimal currentDamage)
        {

            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }

            if (this.rounds <= 0)
            {
                // Effect expires after fixed number of rounds
                return currentDamage;
                
            }
            this.rounds--;
            return currentDamage * 2;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.rounds);
        }
    }
}
