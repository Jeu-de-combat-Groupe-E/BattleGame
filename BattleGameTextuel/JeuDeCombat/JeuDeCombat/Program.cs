using System;
using System.Collections.Generic;

namespace JeuxDeCombat2
{
    //Classe qui vont contenir le power, la vie et le nom de la classe choisit
    public class Player
    {
        //"Internal" : permet de pouvoir modifier la valeur des variables
        internal string Name = "";
        internal int Power = 0;
        internal int Life = 0;
    }

    public class Ordinateur
    {
        internal string Name = "";
        internal int Power = 0;
        internal int Life = 0;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            bool isInputCorrect = false;

            //Choisi le mode de jeu (IA vs IA ou Player vs IA)
            int choixMode = 0;

            while (isInputCorrect != true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow; //Changement de couleur du texte

                //Titre
                Console.WriteLine(" ______              _      _     __                ______                                 \r\n|_   _ \\            / |_   / |_  [  |             .' ___  |                                \r\n  | |_) |   ,--.   `| |-' `| |-'  | |   .---.    / .'   \\_|   ,--.    _ .--..--.    .---.  \r\n  |  __'.  `'_\\ :   | |    | |    | |  / /__\\\\   | |   ____  `'_\\ :  [ `.-. .-. |  / /__\\\\ \r\n _| |__) | // | |,  | |,   | |,   | |  | \\__.,   \\ `.___]  | // | |,  | | | | | |  | \\__., \r\n|_______/  \\'-;__/  \\__/   \\__/  [___]  '.__.'    `._____.'  \\'-;__/ [___||__||__]  '.__.' \r\n                                                                                           \r\n\r\n");

                //Choix mode de jeu
                Console.WriteLine("Choissisez votre mode de jeu");
                Console.WriteLine("1 - Simulation (IA vs IA)");
                Console.WriteLine("2 - Combat (Joueur vs IA)");
                choixMode = int.Parse(Console.ReadLine());

                if (choixMode == 1 || choixMode == 2)
                {
                    isInputCorrect = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Votre entrée n'est pas valide.\n");
                }
            }

            Console.Clear();

            //Mode Simulation
            if (choixMode == 1)
            {
                Simulation();
            }
            else
            {
                //Choisi la difficulté
                int choixDifficulte = 0;

                isInputCorrect = false;
                while (isInputCorrect != true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    //Titre
                    Console.WriteLine(" ______              _      _     __                ______                                 \r\n|_   _ \\            / |_   / |_  [  |             .' ___  |                                \r\n  | |_) |   ,--.   `| |-' `| |-'  | |   .---.    / .'   \\_|   ,--.    _ .--..--.    .---.  \r\n  |  __'.  `'_\\ :   | |    | |    | |  / /__\\\\   | |   ____  `'_\\ :  [ `.-. .-. |  / /__\\\\ \r\n _| |__) | // | |,  | |,   | |,   | |  | \\__.,   \\ `.___]  | // | |,  | | | | | |  | \\__., \r\n|_______/  \\'-;__/  \\__/   \\__/  [___]  '.__.'    `._____.'  \\'-;__/ [___||__||__]  '.__.' \r\n                                                                                           \r\n\r\n");

                    //Choix difficulté
                    Console.WriteLine("Choissisez la difficulté de l'IA");
                    Console.WriteLine("1 - Mode normal");
                    Console.WriteLine("2 - Mode difficile");
                    choixDifficulte = int.Parse(Console.ReadLine());

                    if (choixDifficulte == 1 || choixDifficulte == 2)
                    {
                        isInputCorrect = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Votre entrée n'est pas valide.\n");
                    }
                }

                Console.Clear();

                //Construction classe
                var classeHumain = new Player();
                var classeOrdi = new Ordinateur();

                //Choix classe humain
                int choixH = 0;

                //Boucle pour vérifier si le joueur fait les bon input
                isInputCorrect = false;
                while (isInputCorrect != true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    //Titre
                    Console.WriteLine(" ______              _      _     __                ______                                 \r\n|_   _ \\            / |_   / |_  [  |             .' ___  |                                \r\n  | |_) |   ,--.   `| |-' `| |-'  | |   .---.    / .'   \\_|   ,--.    _ .--..--.    .---.  \r\n  |  __'.  `'_\\ :   | |    | |    | |  / /__\\\\   | |   ____  `'_\\ :  [ `.-. .-. |  / /__\\\\ \r\n _| |__) | // | |,  | |,   | |,   | |  | \\__.,   \\ `.___]  | // | |,  | | | | | |  | \\__., \r\n|_______/  \\'-;__/  \\__/   \\__/  [___]  '.__.'    `._____.'  \\'-;__/ [___||__||__]  '.__.' \r\n                                                                                           \r\n\r\n");

                    //Affichage un résumé des personnage
                    //Résumé damager
                    Console.WriteLine("  ___                                     \r\n |   \\  __ _  _ __   __ _  __ _  ___  _ _ \r\n | |) |/ _` || '  \\ / _` |/ _` |/ -_)| '_|\r\n |___/ \\__,_||_|_|_|\\__,_|\\__, |\\___||_|  \r\n                          |___/           \r\n\r");
                    Console.WriteLine("Le damager possède un power de deux, a trois points de vie, et son attaque spéciale consiste à renvoyer les dégâts qu'il a subi.\nIl est très puissant contre l'archer, moins contre les autres classe\n");

                    //Résumé healer
                    Console.WriteLine("  _  _             _           \r\n | || | ___  __ _ | | ___  _ _ \r\n | __ |/ -_)/ _` || |/ -_)| '_|\r\n |_||_|\\___|\\__,_||_|\\___||_|  \r\n                               ");
                    Console.WriteLine("Le healer possède un power d'un, à quatre points de vie, et son attaque spéciale permet de lui régénérer deux points de vie.\nIl gagne contre la plupart des autres classe, sauf contre l'archer\n");

                    //Résumé tank
                    Console.WriteLine("  _____             _   \r\n |_   _|__ _  _ _  | |__\r\n   | | / _` || ' \\ | / /\r\n   |_| \\__,_||_||_||_\\_\\\r\n                        ");
                    Console.WriteLine("Le tank possède un power d'un, à cinq points de vie, et son attaque spéciale lui enlève un point de vie mais lui augmente son power d'un. Cette attaque permet de percer la défense\nIl n'est puissant que contre le damager\n");

                    //Résumé archer
                    Console.WriteLine("    _             _              \r\n   /_\\   _ _  __ | |_   ___  _ _ \r\n  / _ \\ | '_|/ _|| ' \\ / -_)| '_|\r\n /_/ \\_\\|_|  \\__||_||_|\\___||_|  \r\n                                 ");
                    Console.WriteLine("L'archer possède un power variant d'un à deux, trois points de vie, et son attaque spéciale à une chance sur cinq de one shot l'adversaire.\nSon attaque a aussi une chance sur deux de bloquer un dégât. Il est très fort contre les autres personnage, mais perd facilement contre le damager\n");

                    //Choix personnage
                    Console.WriteLine("Choisis ton personnage.");
                    Console.WriteLine("1 - Damager");
                    Console.WriteLine("2 - Healer");
                    Console.WriteLine("3 - Tank");
                    Console.WriteLine("4 - Archer");
                    choixH = int.Parse(Console.ReadLine());

                    if (choixH == 1 || choixH == 2 || choixH == 3 || choixH == 4)
                    {
                        isInputCorrect = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Votre entrée n'est pas valide.\n");
                    }
                }

                //Attribution classe
                if (choixH == 1)
                {
                    classeHumain.Name = "Damager";
                    classeHumain.Power = 2;
                    classeHumain.Life = 3;
                }
                else if (choixH == 2)
                {
                    classeHumain.Name = "Healer";
                    classeHumain.Power = 1;
                    classeHumain.Life = 4;
                }
                else if (choixH == 3)
                {
                    classeHumain.Name = "Tank";
                    classeHumain.Power = 1;
                    classeHumain.Life = 5;
                }
                else if (choixH == 4)
                {
                    classeHumain.Name = "Archer";
                    classeHumain.Power = 2;
                    classeHumain.Life = 3;
                }

                //Choix random de classe
                Random r = new Random();
                int choixO = r.Next(1, 5);

                //Choix classe ordi
                if (choixO == 1)
                {
                    classeOrdi.Name = "Damager";
                    classeOrdi.Power = 2;
                    classeOrdi.Life = 3;
                }
                else if (choixO == 2)
                {
                    classeOrdi.Name = "Healer";
                    classeOrdi.Power = 1;
                    classeOrdi.Life = 4;
                }
                else if (choixO == 3)
                {
                    classeOrdi.Name = "Tank";
                    classeOrdi.Power = 1;
                    classeOrdi.Life = 5;
                }
                else if (choixO == 4)
                {
                    classeOrdi.Name = "Archer";
                    classeOrdi.Power = 2;
                    classeOrdi.Life = 3;
                }

                Console.Clear();
                //Titre
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" ______              _      _     __                ______                                 \r\n|_   _ \\            / |_   / |_  [  |             .' ___  |                                \r\n  | |_) |   ,--.   `| |-' `| |-'  | |   .---.    / .'   \\_|   ,--.    _ .--..--.    .---.  \r\n  |  __'.  `'_\\ :   | |    | |    | |  / /__\\\\   | |   ____  `'_\\ :  [ `.-. .-. |  / /__\\\\ \r\n _| |__) | // | |,  | |,   | |,   | |  | \\__.,   \\ `.___]  | // | |,  | | | | | |  | \\__., \r\n|_______/  \\'-;__/  \\__/   \\__/  [___]  '.__.'    `._____.'  \\'-;__/ [___||__||__]  '.__.' \r\n                                                                                           \r\n\r\n");

                //Affichage du choix des classe
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\nVous avez choisi la classe {0}.", classeHumain.Name);
                Console.WriteLine("L'ordinateur a choisi la classe {0}.", classeOrdi.Name);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n########### Début du combat ###########\n");

                //Début de la boucle
                bool isFinish = false;

                while (isFinish != true)
                {
                    int choixHumain = 0;
                    int choixOrdi = 0;

                    //Bonne input ?
                    isInputCorrect = false;
                    while (isInputCorrect != true)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        //Choix action joueur
                        Console.WriteLine("1 - Attaquer");
                        Console.WriteLine("2 - Se défendre");
                        Console.WriteLine("3 - Attaque spéciale");
                        choixHumain = int.Parse(Console.ReadLine());

                        if (choixHumain == 1 || choixHumain == 2 || choixHumain == 3)
                        {
                            isInputCorrect = true;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Votre entrée n'est pas valide.\n");
                        }
                    }

                    //Change selon la difficulté de l'IA
                    if (choixDifficulte == 1)
                    {
                        //Choix random de l'action de l'ordi
                        choixOrdi = r.Next(1, 4);
                    }
                    else
                    {
                        //Choix plus poussé de l'ordi
                        choixOrdi = AdvanceIA(choixO);
                    }

                    Console.ForegroundColor = ConsoleColor.White;
                    //Affichage choix
                    if (choixOrdi == 1) { Console.WriteLine("\nL'ordinateur attaque."); }
                    else if (choixOrdi == 2) { Console.WriteLine("\n\nL'ordinateur se défend."); }
                    else if (choixOrdi == 3) { Console.WriteLine("\nL'ordinateur utilise son attaque spéciale !"); }

                    int degatHumain = 0;
                    int degatOrdi = 0;

                    //Savoir si le joueur ou l'ordi se défends
                    bool isHDefend = false;
                    bool isODefend = false;

                    //Pour l'archer
                    bool isHide = false;
                    bool oneShot;

                    //Evenement selon les attaque
                    if (choixHumain == 1)
                    {
                        if (classeHumain.Name == "Archer") //On vérifie si le joueur à la classe archer, car celle-ci possède une attaque différente
                        {
                            isHide = false;
                            degatOrdi += AttaqueArcher(ref isHide);

                            if (isHide == true) { degatHumain -= 1; isHDefend = true; } //Si l'archer arrive à se cacher, il bloque un dégâts
                        }
                        else
                        {
                            degatOrdi += classeHumain.Power; //Si le joueur attaque, on ajoute au dégat ordi le power du joueur
                        }
                    }
                    else if (choixHumain == 2) { degatHumain -= classeOrdi.Power; isHDefend = true; } //Si le joueur se défend, on enlève au dégat du joueur le power de l'ordi


                    if (choixOrdi == 1)
                    {
                        if (classeOrdi.Name == "Archer") //On vérifie si le joueur à la classe archer, car celle-ci possède une attaque différente
                        {
                            isHide = false;
                            degatHumain += AttaqueArcher(ref isHide);

                            if (isHide == true) { degatOrdi -= 1; isODefend = true; } //Si l'archer arrive à se cacher, il bloque un dégâts
                        }
                        else
                        {
                            degatHumain += classeOrdi.Power; //Si l'ordi attaque, on ajoute au dégat humain le power de l'ordi
                        }
                    }
                    else if (choixOrdi == 2) { degatOrdi -= classeHumain.Power; isODefend = true; } //Si l'ordi se défends, on enlève au dégat de l'ordi le power du joueur

                    //Si attaque spécial
                    if (choixHumain == 3)
                    {
                        if (classeHumain.Name == "Damager")
                        {
                            if (degatHumain > 0)
                            {
                                degatOrdi += degatHumain; //Renvoie les dégats pris par le joueur à l'adversaire, uniquement si les dégats sont positif
                            }
                        }
                        else if (classeHumain.Name == "Healer") { degatHumain = SpecialHeal(degatHumain); } //Utilise la fonction pour heal
                        else if (classeHumain.Name == "Tank")
                        {
                            degatHumain += 1; //Se prend un dégât
                            degatOrdi = SpecialTank(degatOrdi); //Appelle fonction
                        }
                        else if (classeHumain.Name == "Archer")
                        {
                            oneShot = false;
                            oneShot = SpecialArcher(); //Appelle fonction

                            if (oneShot == true)
                            {
                                degatOrdi += 999999999; //One shot l'adversaire
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Votre attaque spécial a raté.");
                            }
                        }
                    }

                    //Si attaque spécial (pour l'ordi cette fois)
                    if (choixOrdi == 3)
                    {
                        if (classeOrdi.Name == "Damager")
                        {
                            if (degatOrdi > 0)
                            {
                                degatHumain += degatOrdi; //Renvoie les dégâts subi
                            }
                        }
                        else if (classeOrdi.Name == "Healer") { degatOrdi = SpecialHeal(degatOrdi); }
                        else if (classeOrdi.Name == "Tank")
                        {
                            degatOrdi += 1;
                            degatHumain = SpecialTank(degatHumain);
                        }
                        else if (classeOrdi.Name == "Archer")
                        {
                            oneShot = false;
                            oneShot = SpecialArcher();

                            if (oneShot == true)
                            {
                                degatHumain += 999999999; //One shot l'adversaire
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("L'attaque spécial de l'ordinateur a raté.");
                            }
                        }
                    }

                    //Si l'ordinateur ou le joueur c'est défendue, mais que celui-ci n'a pas attaqué (deux défense ou défense spécial healer),
                    //alors on remet tout à zéro pour éviter les soins
                    if (isHDefend == true && degatHumain < 0) { degatHumain = 0; }
                    if (isODefend == true && degatOrdi < 0) { degatOrdi = 0; }

                    //Affiche un message différent selon si le joueur ou l'ordi c'est soigné ou s'il à infligé des dégat
                    if (degatHumain < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        classeHumain.Life += Math.Abs(degatHumain);
                        Console.WriteLine("\nVous vous êtes soigné de {0} point(s) de vie.", Math.Abs(degatHumain));
                        degatHumain = 0;
                    }
                    else
                    {
                        if (degatOrdi < 0) //Fix à un problème : Si l'ordinateur se soignait, affichait que nous avions mis - 2 dégat
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("\nVous avez infligé 0 dégât(s) à l'ordinateur !");
                        }
                        else
                        {
                            //Affiche les dégâts infligés
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nVous avez infligé {0} dégât(s) à l'ordinateur !", degatOrdi);
                        }
                    }

                    if (degatOrdi < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        classeOrdi.Life += Math.Abs(degatOrdi);
                        Console.WriteLine("L'ordinateur s'est soigné de {0} point(s) de vie.", Math.Abs(degatOrdi)); //Permet de passer un nombre négatif en positif
                        degatOrdi = 0;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("L'ordinateur vous a infligé {0} dégat(s) !", degatHumain);
                    }

                    //Enlève les dégâts subit à la vie
                    classeHumain.Life -= degatHumain;
                    classeOrdi.Life -= degatOrdi;

                    //Permet d'éviter que la vie aille en dessous de 0
                    if (classeHumain.Life <= 0) { classeHumain.Life = 0; }
                    if (classeOrdi.Life <= 0) { classeOrdi.Life = 0; }

                    //Affiche les point de vie restant
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nIl vous reste {0} point(s) de vie.", classeHumain.Life);
                    Console.WriteLine("Il reste à l'ordinateur {0} point(s) de vie.\n", classeOrdi.Life);

                    if (classeHumain.Life <= 0 || classeOrdi.Life <= 0) { isFinish = true; }

                }

                //Affichage fin
                if (classeHumain.Life <= 0 && classeOrdi.Life <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Égalité, personne n'a gagné.");
                }
                else if (classeHumain.Life <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dommage, vous avez perdu.");
                }
                else if (classeOrdi.Life <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bravo ! Vous avez gagné.");
                }

                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        //Simulation. Va retirer tout les affichage inutile, faire en sorte que ce soit deux ordi qui ce batte entre eux avec choix aléatoire et mettre les valeur de victoire et défaite dans un dico
        static void Simulation()
        {
            Dictionary<string, int> valeurVictoire = new Dictionary<string, int>();

            int victoireClasse1 = 0;
            int victoireClasse2 = 0;
            int egalite = 0;

            //Va faire 1000 essai et récupérer les résultat, puis les transformé en pourcentage
            for (int i = 0; i < 601; i++)
            {

                int choixH = 0;
                int choixO = 0;

                //On commence damager contre archer, puis healer contre archer, etc
                if (i < 100)
                {
                    //Damager contre Archer
                    choixH = 1;
                    choixO = 4;
                }
                else if (i < 200)
                {
                    //Damager contre Tank
                    choixH = 1;
                    choixO = 3;
                }
                else if (i < 300)
                {
                    //Damager contre Healer
                    choixH = 1;
                    choixO = 2;
                }
                else if (i < 400)
                {
                    //Healer contre Archer
                    choixH = 2;
                    choixO = 4;
                }
                else if (i < 500)
                {
                    //Healer contre Tank
                    choixH = 2;
                    choixO = 3;
                }
                else if (i < 600)
                {
                    //Tank contre Archer
                    choixH = 2;
                    choixO = 4;
                }

                //Construction classe
                var classeOrdi1 = new Player();
                var classeOrdi2 = new Ordinateur();

                //Attribution classe
                if (choixH == 1)
                {
                    classeOrdi1.Name = "Damager";
                    classeOrdi1.Power = 2;
                    classeOrdi1.Life = 3;
                }
                else if (choixH == 2)
                {
                    classeOrdi1.Name = "Healer";
                    classeOrdi1.Power = 1;
                    classeOrdi1.Life = 4;
                }
                else if (choixH == 3)
                {
                    classeOrdi1.Name = "Tank";
                    classeOrdi1.Power = 1;
                    classeOrdi1.Life = 5;
                }
                else if (choixH == 4)
                {
                    classeOrdi1.Name = "Archer";
                    classeOrdi1.Power = 2;
                    classeOrdi1.Life = 3;
                }

                //Choix classe ordi
                if (choixO == 1)
                {
                    classeOrdi2.Name = "Damager";
                    classeOrdi2.Power = 2;
                    classeOrdi2.Life = 3;
                }
                else if (choixO == 2)
                {
                    classeOrdi2.Name = "Healer";
                    classeOrdi2.Power = 1;
                    classeOrdi2.Life = 4;
                }
                else if (choixO == 3)
                {
                    classeOrdi2.Name = "Tank";
                    classeOrdi2.Power = 1;
                    classeOrdi2.Life = 5;
                }
                else if (choixO == 4)
                {
                    classeOrdi2.Name = "Archer";
                    classeOrdi2.Power = 2;
                    classeOrdi2.Life = 3;
                }

                //Début de la boucle
                bool isFinish = false;

                while (isFinish != true)
                {
                    int choixHumain;
                    int choixOrdi;

                    Random r = new Random();
                    choixHumain = r.Next(1, 4);

                    //Choix random de l'action de l'ordi
                    choixOrdi = r.Next(1, 4);

                    int degatHumain = 0;
                    int degatOrdi = 0;

                    //Savoir si le joueur ou l'ordi se défends
                    bool isHDefend = false;
                    bool isODefend = false;

                    //Pour l'archer
                    bool isHide = false;
                    bool oneShot;

                    //Evenement selon les attaque
                    if (choixHumain == 1)
                    {
                        if (classeOrdi1.Name == "Archer") //On vérifie si le joueur à la classe archer, car celle-ci possède une attaque différente
                        {
                            isHide = false;
                            degatOrdi += AttaqueArcher(ref isHide);

                            if (isHide == true) { degatHumain -= 1; isHDefend = true; } //Si l'archer arrive à se cacher, il bloque un dégâts
                        }
                        else
                        {
                            degatOrdi += classeOrdi1.Power; //Si le joueur attaque, on ajoute au dégat ordi le power du joueur
                        }
                    }
                    else if (choixHumain == 2) { degatHumain -= classeOrdi2.Power; isHDefend = true; } //Si le joueur se défend, on enlève au dégat du joueur le power de l'ordi


                    if (choixOrdi == 1)
                    {
                        if (classeOrdi2.Name == "Archer") //On vérifie si le joueur à la classe archer, car celle-ci possède une attaque différente
                        {
                            isHide = false;
                            degatHumain += AttaqueArcher(ref isHide);

                            if (isHide == true) { degatOrdi -= 1; isODefend = true; } //Si l'archer arrive à se cacher, il bloque un dégâts
                        }
                        else
                        {
                            degatHumain += classeOrdi2.Power; //Si l'ordi attaque, on ajoute au dégat humain le power de l'ordi
                        }
                    }
                    else if (choixOrdi == 2) { degatOrdi -= classeOrdi1.Power; isODefend = true; } //Si l'ordi se défends, on enlève au dégat de l'ordi le power du joueur

                    //Si attaque spécial
                    if (choixHumain == 3)
                    {
                        if (classeOrdi1.Name == "Damager")
                        {
                            if (degatHumain > 0)
                            {
                                degatOrdi += degatHumain; //Renvoie les dégats pris par le joueur à l'adversaire, uniquement si les dégats sont positif
                            }
                        }
                        else if (classeOrdi1.Name == "Healer") { degatHumain = SpecialHeal(degatHumain); }
                        else if (classeOrdi1.Name == "Tank")
                        {
                            degatHumain += 1;
                            degatOrdi = SpecialTank(degatOrdi);
                        }
                        else if (classeOrdi1.Name == "Archer")
                        {
                            oneShot = false;
                            oneShot = SpecialArcher();

                            if (oneShot == true)
                            {
                                degatOrdi += 999999999; //One shot l'adversaire
                            }
                        }
                    }

                    //Si attaque spécial
                    if (choixOrdi == 3)
                    {
                        if (classeOrdi2.Name == "Damager")
                        {
                            if (degatOrdi > 0)
                            {
                                degatHumain += degatOrdi;
                            }
                        }
                        else if (classeOrdi2.Name == "Healer") { degatOrdi = SpecialHeal(degatOrdi); }
                        else if (classeOrdi2.Name == "Tank")
                        {
                            degatOrdi += 1;
                            degatHumain = SpecialTank(degatHumain);
                        }
                        else if (classeOrdi2.Name == "Archer")
                        {
                            oneShot = false;
                            oneShot = SpecialArcher();

                            if (oneShot == true)
                            {
                                degatHumain += 999999999; //One shot l'adversaire
                            }
                        }
                    }

                    //Si l'ordinateur ou le joueur c'est défendue, mais que celui-ci n'a pas attaqué (deux défense ou défense spécial healer),
                    //alors on remet tout à zéro pour éviter les soins
                    if (isHDefend == true && degatHumain < 0) { degatHumain = 0; }
                    if (isODefend == true && degatOrdi < 0) { degatOrdi = 0; }

                    //Affiche un message différent selon si le joueur ou l'ordi c'est soigné ou s'il à infligé des dégat
                    if (degatHumain < 0)
                    {
                        classeOrdi1.Life += Math.Abs(degatHumain);
                        degatHumain = 0;
                    }

                    if (degatOrdi < 0)
                    {
                        classeOrdi2.Life += Math.Abs(degatOrdi);
                        degatOrdi = 0;
                    }

                    classeOrdi1.Life -= degatHumain;
                    classeOrdi2.Life -= degatOrdi;

                    if (classeOrdi1.Life <= 0 || classeOrdi2.Life <= 0) { isFinish = true; }

                }

                //Incrémentation de fin
                if (classeOrdi1.Life <= 0 && classeOrdi2.Life <= 0)
                {
                    egalite += 1;
                }
                else if (classeOrdi2.Life <= 0)
                {
                    victoireClasse1 += 1;
                }
                else if (classeOrdi1.Life <= 0)
                {
                    victoireClasse2 += 1;
                }

                //Incrémentation victoire : Il va y avoir 100 test de chaque un contre un
                if (i == 100)
                {
                    valeurVictoire.Add("Nombre de victoire : Damager Vs Archer", victoireClasse1);
                    valeurVictoire.Add("Nombre de victoire : Archer Vs Damager", victoireClasse2);

                    //On réinitialise les valeurs
                    victoireClasse1 = 0;
                    victoireClasse2 = 0;
                }
                else if (i == 200)
                {
                    valeurVictoire.Add("Nombre de victoire : Damager Vs Tank", victoireClasse1);
                    valeurVictoire.Add("Nombre de victoire : Tank Vs Damager", victoireClasse2);

                    victoireClasse1 = 0;
                    victoireClasse2 = 0;
                }
                else if (i == 300)
                {
                    valeurVictoire.Add("Nombre de victoire : Damager Vs Healer", victoireClasse1);
                    valeurVictoire.Add("Nombre de victoire : Healer Vs Damager", victoireClasse2);

                    victoireClasse1 = 0;
                    victoireClasse2 = 0;
                }
                else if (i == 400)
                {
                    valeurVictoire.Add("Nombre de victoire : Healer Vs Archer", victoireClasse1);
                    valeurVictoire.Add("Nombre de victoire : Archer Vs Healer", victoireClasse2);

                    victoireClasse1 = 0;
                    victoireClasse2 = 0;
                }
                else if (i == 500)
                {
                    valeurVictoire.Add("Nombre de victoire : Healer Vs Tank", victoireClasse1);
                    valeurVictoire.Add("Nombre de victoire : Tank Vs Healer", victoireClasse2);

                    victoireClasse1 = 0;
                    victoireClasse2 = 0;
                }
                else if (i == 600)
                {
                    valeurVictoire.Add("Nombre de victoire : Tank Vs Archer", victoireClasse1);
                    valeurVictoire.Add("Nombre de victoire : Archer Vs Tank", victoireClasse2);

                    victoireClasse1 = 0;
                    victoireClasse2 = 0;
                }
            }

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            //Titre
            Console.WriteLine(" ______              _      _     __                ______                                 \r\n|_   _ \\            / |_   / |_  [  |             .' ___  |                                \r\n  | |_) |   ,--.   `| |-' `| |-'  | |   .---.    / .'   \\_|   ,--.    _ .--..--.    .---.  \r\n  |  __'.  `'_\\ :   | |    | |    | |  / /__\\\\   | |   ____  `'_\\ :  [ `.-. .-. |  / /__\\\\ \r\n _| |__) | // | |,  | |,   | |,   | |  | \\__.,   \\ `.___]  | // | |,  | | | | | |  | \\__., \r\n|_______/  \\'-;__/  \\__/   \\__/  [___]  '.__.'    `._____.'  \\'-;__/ [___||__||__]  '.__.' \r\n                                                                                           \r\n\r\n");

            foreach (var dico in valeurVictoire)
            {
                //Changement de couleur selon si la classe est majoritaire ou non
                if (dico.Value > 50) { Console.ForegroundColor = ConsoleColor.Green; }
                else { Console.ForegroundColor = ConsoleColor.Red; }
                Console.WriteLine("{0} : {1} %", dico.Key, dico.Value);
            }

            //Calcul le pourcentage d'égalité global
            egalite = (egalite * 100) / 600;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Nombre d'égalité : {0} %", egalite);

            Console.ForegroundColor = ConsoleColor.White;
        }

        static int SpecialHeal(int degat)
        {
            return degat - 2; //Soigne de deux point de vie
        }

        static int SpecialTank(int degat)
        {
            degat += 2;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n1 PV à été sacrifié");
            return degat;
        }

        static int AttaqueArcher(ref bool isHide)
        {
            //Soit il va mettre un dégat, soit 2, et soit il va réussir à se cacher ou non
            Random r = new Random();
            int randomDegat = r.Next(1, 3);
            int randomMiss = r.Next(0, 2);

            if (randomMiss == 0)
            {
                isHide = true; //Si zéro, il arrive à se cacher
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nUn dégâts à été bloqué !");
            }

            return randomDegat;
        }

        static bool SpecialArcher()
        {
            //1 chance sur 5 de mettre un headshot
            Random r = new Random();
            int randomHeadShot = r.Next(0, 5);

            if (randomHeadShot == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nHeadShot !");
                return true; //Si randomHeadShot égal à 0, alors one shot
            }

            return false; //Sinon pas des headshot
        }

        //Advance IA va rendre l'IA plus difficle à battre car celle-ci, au lieu de faire des choix aléatoire, va faire des choix optimisé par rapport à sa classe
        static int AdvanceIA(int classe)
        {
            Random r = new Random();
            int random = 0;
            random = r.Next(1, 11);
            int choixIA = 0;

            //Pour le damager, va privilégier l'attaque et la défence
            if (classe == 1)
            {
                if (random <= 4) { choixIA = 1; }
                else if (random <= 8) { choixIA = 2; }
                else { choixIA = 3; }

                return choixIA;
            }
            //Pour le healer, va privilégier l'attaque spécial et l'attaque
            else if (classe == 2)
            {
                if (random <= 4) { choixIA = 3; }
                else if (random <= 8) { choixIA = 1; }
                else { choixIA = 2; }

                return choixIA;
            }
            //Pour le tank, va privilégier la défence et la capacité spécial
            else if (classe == 3)
            {
                if (random <= 4) { choixIA = 2; }
                else if (random <= 8) { choixIA = 3; }
                else { choixIA = 1; }

                return choixIA;
            }
            //Pour l'archer, va privilégier la défense et l'attaque spécial
            else if (classe == 4)
            {
                if (random <= 4) { choixIA = 3; }
                else if (random <= 7) { choixIA = 2; }
                else { choixIA = 1; }

                return choixIA;
            }

            return choixIA;
        }
    }
}
