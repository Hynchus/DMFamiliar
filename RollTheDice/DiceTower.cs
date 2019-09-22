using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollTheDice {
    public static class DiceTower {
        private static Random seed = new Random();

        public static int SumModifiers(List<StructCollection.Mod> modifiers) {
            int sum = 0;
            foreach (StructCollection.Mod mod in modifiers) {
                sum += mod.magnitude;
            }
            return sum;
        }

        public static int RollDie(int count, int faces) {
            int result = 0;
            for (int i = 0; i < count; i++) {
                result += seed.Next(1, faces + 1);
            }
            return result;
        }

        public static int RollDice(List<StructCollection.Die> dice) {
            int sum = 0;
            foreach (StructCollection.Die die in dice) {
                sum += RollDie(die.count, die.faces);
            }
            return sum;
        }

        public static int RollDice(List<StructCollection.Die> dice, List<StructCollection.Mod> modifiers) {
            return RollDice(dice) + SumModifiers(modifiers);
        }
    }
}
