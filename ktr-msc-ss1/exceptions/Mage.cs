using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktr_msc_ss1
{
    public class Mage : Character
    {
        public Mage(string nameCharac)
            : base(nameCharac, "Mage")
        {
            life = 70;
            strength = 3;
            agility = 10;
            wit = 10;
            Console.WriteLine(nameCharac + ": May the gods be with me.");
        }

        public override void Attack(string weapon)
        {
            base.Attack(weapon);

            if (weapon == "magic" || weapon == "wand")
            {                
                Console.WriteLine(GetName() + " : Feel the power of my " + weapon + " !");
            }
            else
            {
                throw new WeaponException(GetName() + ": I don't need this stupid " + weapon + "! Don't misjudge my powers !");
            }
        }

        public override void moveRight()
        {
            Console.WriteLine(GetName() + ": moves right furtively.");
        }

        public override void moveLeft()
        {
            Console.WriteLine(GetName() + ": moves left furtively.");
        }

        public override void moveForward()
        {
            Console.WriteLine(GetName() + ": moves forward furtively.");
        }

        public override void moveBack()
        {
            Console.WriteLine(GetName() + ": moves back furtively.");
        }
    }
}
