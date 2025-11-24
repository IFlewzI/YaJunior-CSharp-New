using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_2._11
{
    class Program
    {
        static void Main()
        {
            const string SwordAttackCommand = "1";
            const string SpellCastCommand = "2";
            const string SelfHealingCommand = "3";

            Random random = new Random();
            string userInput;

            int playerMaxHp = 35;
            int playerHp = playerMaxHp;
            int playerMaxMana = 6;
            int playerMana = playerMaxMana;

            int playerSwordAttackDamage = 10;
            int playerSpellManaCost = 2;
            bool isPlayerSpellSecondaryDamageReady = false;
            int playerSpellPrimaryDamage = 7;
            int playerSpellSecondaryDamage = 25;
            int playerSelfHealingUsesMaxQuantity = 2;
            int playerSelfHealingUsesQuantity = playerSelfHealingUsesMaxQuantity;
            int playerSelfHealingHpRecovery = 15;
            int playerSelfHealingManaRecovery = 3;
            int playerSavingThrowMinResult = 1;
            int playerSavingThrowMaxResult = 20;
            int playerSavingThrowResult;
            int playerCounterAttackDamage = 25;

            int enemyMaxHp = 135;
            int enemyHp = enemyMaxHp;
            int enemyAttackType;
            int enemyAttackDamage = 0;
            int enemyClawsAttackMinDamage = 5;
            int enemyClawsAttackMaxDamage = 9;
            int enemyTailAttackMinDamage = 4;
            int enemyTailAttackMaxDamage = 6;
            int enemyBiteAttackMinDamage = 9;
            int enemyBiteAttackMaxDamage = 14;

            Console.WriteLine("После длительного похода и орд монстров, убитых на пути, вы наконец приближаетесь к логову мантикоры, опаснейшего противника, что может с лёгкостью унести вашу жизнь." +
                "\nВы обнажаете клинок, вызывая чудище на поединок. От волнения ваши руки дрожат, ведь вы понимаете, что либо убьёте вы, либо убьют вас\n");

            while (playerHp > 0 && enemyHp > 0)
            {
                Console.WriteLine($"Начало раунда." +
                    $"\nВаше здоровье: {playerHp}" +
                    $"\nЗдоровье противника: {enemyHp}");

                Console.Write($"\nДоступные действия: " +
                    $"\nКоманда \"{SwordAttackCommand}\" - Удар мечом" +
                    $"\nКоманда \"{SpellCastCommand}\" - Ведьмин снаряд (Осталось маны: {playerMana}. Нужно для применения: {playerSpellManaCost})" +
                    $"\nКоманда \"{SelfHealingCommand}\" - Исцеление (осталось использований: {playerSelfHealingUsesQuantity})" +
                    $"\n\nВведите команду активации желаемого действия. Поле для ввода: ");
                userInput = Console.ReadLine();

                if (userInput == SwordAttackCommand)
                {
                    Console.WriteLine($"\nВы проводите атаку мечом. Вы наносите {playerSwordAttackDamage} урона");
                    enemyHp -= playerSwordAttackDamage;
                }
                else if (userInput == SpellCastCommand)
                {
                    if (playerMana >= playerSpellManaCost)
                    {
                        playerMana -= playerSpellManaCost;

                        if (isPlayerSpellSecondaryDamageReady == false)
                        {
                            Console.WriteLine($"\nВы выпускаете из рук луч потрескивающей синеватой энергии. Вы наносите {playerSpellPrimaryDamage} урона." +
                                $"\nТело врага становится испещрено магическими узорами, вам же осталось лишь активировать проклятие...");
                            enemyHp -= playerSpellPrimaryDamage;
                            isPlayerSpellSecondaryDamageReady = true;
                        }
                        else
                        {
                            Console.WriteLine($"\nВы сжимаете магический артефакт в руке, в то же время узоры на теле противника с треском разрывают плоть, создавая множественные порезы." +
                                $"\nВы наносите {playerSpellSecondaryDamage} урона.");
                            enemyHp -= playerSpellSecondaryDamage;
                            isPlayerSpellSecondaryDamageReady = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nОслеплённые от изнеможения вы пытаетесь воззвать к высшим силам, однако когда небеса не отвечают на вашу просьбу вы понимаете, что ваша мана закончилась..." +
                            "\nПодобные глупые ошибки часто совершают охотники-новички... быть может вы всё-таки не были готовы к этому бою?");
                    }
                }
                else if (userInput == SelfHealingCommand)
                {
                    if (playerSelfHealingUsesQuantity > 0)
                    {
                        playerSelfHealingUsesQuantity--;

                        Console.WriteLine($"\nВы откупориваете драгоценное зелье, которое долгое время берегли ради этого самого момента." +
                            $"\nВыпивая его вы восстанавливаете {Math.Min(playerMaxHp - playerHp, playerSelfHealingHpRecovery)} здоровья " +
                            $"и {Math.Min(playerMaxMana - playerMana, playerSelfHealingManaRecovery)} маны");
                        playerHp = Math.Min(playerHp + playerSelfHealingHpRecovery, playerMaxHp);
                        playerMana = Math.Min(playerMana + playerSelfHealingManaRecovery, playerMaxMana);
                    }
                    else
                    {
                        Console.WriteLine("\nВ пылу сражения вы выхватываете с пояса заветный бутылёк, однако в попытке отпить вас пробивает дрожь, ведь зелье уже закончилось... " +
                            "\nВ то же время монстр уже мчится на вас с намерением разорвать");
                    }
                }
                else
                {
                    Console.WriteLine("\nРастерявшись в пылу боя вы пропускаете возможность для атаки, готовясь к скорой вражеской атаке");
                }

                enemyAttackType = random.Next(0, 3);

                if (enemyAttackType == 0)
                {
                    enemyAttackDamage = random.Next(enemyClawsAttackMinDamage, enemyClawsAttackMaxDamage + 1);
                    Console.WriteLine($"\nМантикора с рёвом атакует вас когтями, нанося {enemyAttackDamage} урона");
                }
                else if (enemyAttackType == 1)
                {
                    enemyAttackDamage = random.Next(enemyTailAttackMinDamage, enemyTailAttackMaxDamage + 1);
                    Console.WriteLine($"\nМантикора распускает шипы на своём хвосте, после чего атакует вас им, нанося {enemyAttackDamage} урона");
                }
                else if (enemyAttackType == 2)
                {
                    Console.WriteLine($"\nМантикора взмахивает крыльями, налетая на вас и атакуя укусом. " +
                        $"\nНажмите Enter, чтобы попытаться пройти спасбросок!");
                    Console.ReadLine();
                    Thread.Sleep(1000);

                    playerSavingThrowResult = random.Next(playerSavingThrowMinResult, playerSavingThrowMaxResult + 1);
                    Console.Write($"\nРезультат броска - {playerSavingThrowResult}. ");

                    if (playerSavingThrowResult == playerSavingThrowMinResult)
                    {
                        Console.WriteLine("Критический провал(" +
                            "\n\nНе совладав с могучим укусом вы угодили прямо в пасть к мантикоре. \n\nВы сожраны.");
                        playerHp = 0;
                    }
                    else if (playerSavingThrowResult == playerSavingThrowMaxResult)
                    {
                        enemyAttackDamage = 0;
                        Console.WriteLine("Критический успех!" +
                            "\n\nВы перепрыгиваете мантикору, отскочив от её головы и полностью избежав урона. Пока вы совершали подобный кульбит вам также удалось полоснуть противника своим мечом" +
                            $"\nВы нанесли {playerCounterAttackDamage} урона.");
                        enemyHp -= playerCounterAttackDamage;
                    }
                    else
                    {
                        enemyAttackDamage = random.Next(enemyBiteAttackMinDamage, enemyBiteAttackMaxDamage + 1);
                        enemyAttackDamage = Convert.ToInt32(enemyAttackDamage * ((float)(playerSavingThrowMaxResult - playerSavingThrowResult) / playerSavingThrowMaxResult));
                        enemyAttackDamage = Math.Max(enemyAttackDamage, 1);
                        Console.WriteLine($"\n\nЧелюсти смыкаются, похрустывая вашей бронёй, сминая ваши органы. " +
                            $"\nВы получили {enemyAttackDamage} урона");
                    }
                }

                playerHp -= enemyAttackDamage;

                if (playerHp > 0 && enemyHp > 0)
                {
                    Console.WriteLine("\nНажмите Enter, чтобы перейти к следующему раунду");
                    Console.ReadLine();
                }
            }

            if (playerHp <= 0 && enemyHp <= 0)
            {
                Console.WriteLine("\nВидя как монстр близко к смерти вы делаете очередной выпад, однако допускаете фатальную ошибку, не оценив угрозу... " +
                    "\nВы убиваете мантикору, однако из последних сил чудище атакует, забирая вас с собой на тот свет");
            }
            else if (playerHp <= 0)
            {
                Console.WriteLine("\nВ жестоком бою, где любая ошибка может привести к смерти, вы проигрываете, погибнув от лап чудовища" +
                    "\nВы мертвы.");
            }
            else if (enemyHp <= 0)
            {
                Console.WriteLine("\nДлительный поход наконец подошёл к концу. Ваша победа над мантикорой принесёт мир в ближайший город, а вас самих запомнят героем" +
                    "\nВы победили!");
            }
        }
    }
}
