using System;

namespace ktr_msc_ss1
{
    public abstract class Character : Movable
    {
        protected string name;
        protected int life = 50;
        protected int agility = 2;
        protected int strength = 2;
        protected int wit = 2;
        readonly string RPGClass;

        public string GetName()
        {
            return name;
        }

        public int GetLife()
        {
            return life;
        }
        public int GetAgility()
        {
            return agility;
        }
        public int GetStrength()
        {
            return strength;
        }
        public int GetWit()
        {
            return wit;
        }
        public string GetRPGClass()
        {
            return RPGClass;
        }


        public Character(string nameCharac, string RPGClassCharac) 
        {
            name = nameCharac;
            RPGClass = RPGClassCharac;
        }

        public virtual void Attack(string weapon)
        {
            if (weapon != "")
            {
                Console.WriteLine(name + ": Rrrrrrrrr ....");
            }
            else
            {
                throw new WeaponException(GetName() + ": I refuse to fight with my bare hands.");
            }
            
        }

        public virtual void moveRight()
        {
            Console.WriteLine(GetName() + ": moves right");
        }

        public virtual void moveLeft()
        {
            Console.WriteLine(GetName() + ": moves left");
        }

        public virtual void moveForward()
        {
            Console.WriteLine(GetName() + ": moves forward");
        }

        public virtual void moveBack()
        {
            Console.WriteLine(GetName() + ": moves back");
        }

        public void Unsheathe()
        {
            Console.WriteLine(GetName() + ": unsheathes his weapon.");
        } 
        
        public void TryToAttack(string weapon)
        {
            try
            {
                Attack(weapon);
            }
            catch (WeaponException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }


}
