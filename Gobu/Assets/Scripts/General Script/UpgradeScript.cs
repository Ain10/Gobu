using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UpgradeScript : MonoBehaviour
{
    [SerializeField] List<Button> button;
    private int gold;
    public int weaponUpgradePrize, armorupgradePrize;

    private void Update()
    {
        gold = FindObjectOfType<ScoreTrack>().GetComponent<ScoreTrack>().gameGold;
        if(gold < weaponUpgradePrize)
        {
            button[0].interactable = false;
        }
        else
        {
            button[0].interactable = true;
        }
        if (gold < armorupgradePrize)
        {
            button[1].interactable = false;
        }
        else
        {
            button[1].interactable = true;
        }
    }

    public void upgradeWeapon()
    {
        FindObjectOfType<ScoreTrack>().GetComponent<ScoreTrack>().gameGold-=weaponUpgradePrize;
        FindObjectOfType<ScoreTrack>().GetComponent<ScoreTrack>().weaponUpgrade+=3;
    }

    public void upgradeArmor()
    {
        FindObjectOfType<ScoreTrack>().GetComponent<ScoreTrack>().gameGold-=armorupgradePrize;
        FindObjectOfType<ScoreTrack>().GetComponent<ScoreTrack>().healthUpgrade+=1;
    }


    public void chooseLVL()
    {
        SceneManager.LoadScene("ChooseLVL");
    }

}
