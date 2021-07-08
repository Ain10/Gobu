using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerSave
{
    public int gold;
    public int sceneLVL;
    public int attackUpgrade;
    public int healthUpgrade;


    public PlayerSave(ScoreTrack player)
    {
        gold = player.gameGold;
        sceneLVL = player.currentScene;
        attackUpgrade = player.weaponUpgrade;
        healthUpgrade = player.healthUpgrade;
    }

}
