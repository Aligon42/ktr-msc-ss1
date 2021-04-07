using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktr_msc_ss1
{
    static class Program 
    {
        static void Main(string[] args)
        {
            Character warrior = new Warrior("Jean-Luc");
            Character mage = new Mage("Robert");

            warrior.TryToAttack("hammer");
            mage.TryToAttack("magic");
            mage.TryToAttack("stick");
            mage.TryToAttack("");

            warrior.moveBack();
            warrior.moveForward();
            warrior.moveLeft();
            warrior.moveRight();
            mage.moveRight();
            mage.moveLeft();
            mage.moveBack();
            mage.moveForward();
        } 



    }
}
