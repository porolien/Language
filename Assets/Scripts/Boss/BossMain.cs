using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMain : MonoBehaviour
{
    public BossStats bossStats;
    public BossCollision bossCollision;
    public BossStateMachine bossStateMachine;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Awake()
    {
        SendMessage("Init", this);
    }

}


/*
A une action où il se heal, le joueur doit le bourrer pour arrêter la regen
Autre action où il se met à tourner avec ses lames + il se regen
le joueur doit faire une action en particulier pour l'arreter

fonction pour bouger le boss (script de déplacement)


attaques du boss ( deux armes )
- attaque arme droite
- attaque arme gauche
- les deux armes en même temps (projette une croix)
- se renferme sur lui même + se heal (quand il est low, tourne sur lui même en + de se heal)
- après qu'il soit mid-life peut envoyer 3 tornades de sable autour de lui (mm animation que pour le heal)


STATS (déclarer les stats dans des variables + les fonctions pour les gérer)
mouvements
attaques

*/
