using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMain : MonoBehaviour
{
    public BossStats bossStats;

    // Start is called before the first frame update
    void Awake()
    {
        SendMessage("Init", this);
    }

}


/*
Gérer les HP du boss
Faire une fonction "onHit"
A une action où il se heal, le joueur doit le bourrer pour arrêter la regen
Autre action où il se met à tourner avec ses lames + il se regen
le joueur doit faire une action en particulier pour l'arreter

fonction pour bouger le boss (script de déplacement)



STATS (déclarer les stats dans des variables + les fonctions pour les gérer)
barre de vie
mouvements
attaques

*/
