# Monopoly

## Exercice n°1

1. Créer une énumération `Pions` qui aura pour valeurs : `Voiture`, `Cuirasse`, `Chien`, `Chapeau`, `Fer`, `Dino`, `DeACoudre`, `Brouette`, `Chaussure`
2. Créer une classe statique `De` qui devra implémenter
  - Les variables membres :
    - `valeurMin` (int)
    - `valeurMax` (int)
    - `rng` (Random)
  - La méthode publique :
    - `int[ ] Lancer(int nbDes)` – Permet de lancer des dés, nbDes indiquant le nombre de dés. La valeur de retour correspond aux résultats de tout les dés.
3. Créer une classe `Joueur` qui devra implémenter
  - Les variables membres :
    - `nom` (string)
    - `pion` (Pions)
    - `position` (int) – Position sur le plateau de jeu
  - La méthode publique :
    - `boolAvancer()` – Le joueur lance deux dés et avance de la quantité de cases équivalant au total des dés. Indique en retour si le joueur a obtenu un double.
