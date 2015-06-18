using ArmyOfCreatures.Logic.Specialties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Extended.Specialties
{
    public class AddAttackWhenSkip : Specialty
    {
        private int attackPointsToAdd;

        public AddAttackWhenSkip(int pointsToAdd)
        {
            if (pointsToAdd < 1 && pointsToAdd > 10)
            {
                throw new ArgumentException("Attack points to add must be between 1 and 10!");
            }
            attackPointsToAdd = pointsToAdd;
        }

        public override void ApplyOnSkip(Logic.Battles.ICreaturesInBattle skipCreature)
        {
            if (skipCreature == null)
            {
                throw new ArgumentNullException("skipCreature");
            }

            skipCreature.PermanentAttack += this.attackPointsToAdd;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.attackPointsToAdd);
        }
    }
}
