using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;
using UnityEngine;

public class ScoreTrack : MonoBehaviour
{
    public int lvlCurrency, gameGold;
    public int weaponUpgrade, healthUpgrade;
    public int currentScene;
    // Start is called before the first frame update

    private void Awake()
    {
        PlayerSave playerData = Saving.loadPlayerData();
        gameGold = playerData.gold;
        weaponUpgrade = playerData.attackUpgrade;
        healthUpgrade = playerData.healthUpgrade;
        currentScene = playerData.sceneLVL;
        if(currentScene <= SceneManager.GetActiveScene().buildIndex)
        {
            currentScene = SceneManager.GetActiveScene().buildIndex;
        }

    }

    public void setCurrency(int score)
    {
        this.lvlCurrency = score;
    }
    public int getCurrency()
    {
        return this.lvlCurrency;
    }

    private void Update()
    {
        if(GameObject.FindGameObjectWithTag("Enemy Base")==false)
        {
            Debug.Log("FILE SAVED");
            Time.timeScale = 0;
            Saving.savePlayerData(this);
        }
    }
}
