using System;

namespace turnBased{

    class Program{
        static void Main(string[] args){
            bool isDead = false;
            int playerHp = 100;
            int enemyHp = 20;
            int playerAttack = 8;
            int enemyAttack = 8;
            int playerHeal = 5;
            int enemyHeal = 5;
            Random random = new Random();

            while(playerHp > 0 && enemyHp > 0){
                Console.WriteLine("----- Player turn -----");
                Console.WriteLine("Player Health: " + playerHp);
                Console.WriteLine("What will you do? A to attack or H to heal");
                string playerOption = Console.ReadLine();

                if(playerOption == "A" || playerOption == "a"){
                    enemyHp -= playerAttack;
                    Console.WriteLine("Player dealt: " + playerAttack + " damage");
                    Console.WriteLine("Enemy health is: " + enemyHp);
                }
                else if(playerOption == "H" || playerOption == "h"){
                    playerHp += playerHeal;
                    Console.WriteLine("Player health now: " + playerHp);
                }
                else{
                    Console.WriteLine("Inavlid Input");
                }

                if(enemyHp > 0){
                    Console.WriteLine("----- Enemy Turn -----");
                    Console.WriteLine("Enemy health: " + enemyHp);
                    int enemyChoice = random.Next(0,2);

                    if(enemyChoice == 0){
                        playerHp -= enemyAttack;
                        Console.WriteLine("Enemy attacks and deals: " + enemyAttack + " damage");
                    }
                    else {
                        enemyHp += enemyHeal;
                        Console.WriteLine("Enemy heals: " + enemyHeal + " health");
                    }
                }
            }

            if (playerHp > 0){
                Console.WriteLine("You win");
            }
            else {
                Console.WriteLine("You lose");
            }


        }
    }
}