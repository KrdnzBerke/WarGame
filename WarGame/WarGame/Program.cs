using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 40;
            int enemyHp = 20;

            int playerAttack = 5;
            int enemyAttack = 7;

            int healAmount = 5;

            Random random=new Random();

            while(playerHp>0 && enemyHp > 0)
            {
                //player turn
                Console.WriteLine("--player turn--");
                Console.WriteLine("player hp - " + playerHp + ".enemy hp - " + enemyHp);
                Console.WriteLine("enter 'a' to attack or 'h' to heal. ");

                string choice=Console.ReadLine();
                if (choice == "a")
                {
                    enemyHp -= playerAttack;
                    Console.WriteLine("player restores " + playerAttack + "damage");
                }
                else
                {
                    playerHp = healAmount;
                    Console.WriteLine("player restores " + healAmount + "heal points");
                }

                //enemy turn

                if (enemyHp > 0)
                {
                    Console.WriteLine("--enemy turn");
                    Console.WriteLine("player hp - " + playerHp + ". enemy hp - " + enemyHp);

                    int enemyChoice = random.Next(0,2);

                    if (enemyChoice == 0)
                    {
                        playerHp -= enemyAttack;
                        Console.WriteLine("enemy attacks and deals " + enemyAttack + " damage ");
                    
                    }
                    else
                    {
                        enemyHp += healAmount;
                        Console.WriteLine("enemy restores " + healAmount + "heal points");

                         
                    }
                }
            }
            if(playerHp > 0)
            {
                Console.WriteLine("conratulations,you won");
            }
            else
            {
                Console.WriteLine("you lose");
            }

        }
    }
}
