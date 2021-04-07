using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktr_msc_ss1
{
    public class Warrior : Character
    {

        public Warrior(string nameCharac)
            : base(nameCharac, "Warrior")
        {
            life = 100;
            strength = 10;
            agility = 8;
            wit = 3;
            Console.WriteLine(nameCharac + ": My name will go down in history!");
        }

        public override void Attack(string weapon)
        {
            base.Attack(weapon);

            if (weapon == "hammer" || weapon == "sword")
            {                
                Console.WriteLine(GetName() + " : I'll crush you with my " + weapon + " !");
            }
            else
            {
                throw new WeaponException(GetName() + ": A " + weapon + "?? What should I do with this ?!");
            }
        }

        public override void moveRight()
        {
            Console.WriteLine(GetName() + ": moves right like a bad boy.");
        }

        public override void moveLeft()
        {
            Console.WriteLine(GetName() + ": moves left like a bad boy.");
        }

        public override void moveForward()
        {
            Console.WriteLine(GetName() + ": moves forward like a bad boy.");
        }

        public override void moveBack()
        {
            Console.WriteLine(GetName() + ": moves back like a bad boy.");
        }
    }
}
