# BattleGame

--------------------------------------------------------------------------------------------------------------------------

Comment jouer au jeu :

Lancer la solution, une fenêtre console devrait apparaître. Vous pouvez la mettre en plein écran pour plus de confort.
Différentes options vous seront demandées, pour les sélectionner, merci d'entrer le nombre devant le choix choisi 
(si vous tapez autre chose, il vous sera demandé de retaper un choix valide).

--------------------------------------------------------------------------------------------------------------------------

But du jeu :

Faire tomber les points de vie de votre adversaire à zéro.

--------------------------------------------------------------------------------------------------------------------------

Fonctionnement du code :

Le fonctionnement du code repose principalement sur deux choses :
- Les classes, qui vont contenir les points de vie, le power et le nom des classes choisies.
- Les variables "degatHumain" et "degatOrdi" qui vont contenir les dégâts subis par le joueur et l'ordinateur.

Ces variables vont être positives si des dégâts sont pris, négatives en cas de heal ou de défense.

Exemple : le joueur attaque, degatOrdi prend donc la valeur de son power. Si l'ordi se défend, 
on enlève à la variable degatOrdi le power du joueur.
On se retrouve donc avec 0 dégât infligé des deux côtés, ce que nous voulons (car l'ordinateur a défendu notre attaque).

--------------------------------------------------------------------------------------------------------------------------

Notes de version :

V.1.3.2 (version actuelle) : Correction de bug
V.1.3.1 : Amélioration graphique
V.1.3.0 : Ajout de la difficulté de l'ordinateur
V.1.2.0 : Ajout du mode simulation + ajout de boucle pour éviter les erreurs de frappe
V.1.1.0 : Ajout de la nouvelle classe : Archer
V.1.0.1 : Correction de bug
V.1.0.0 : Code final sans amélioration
