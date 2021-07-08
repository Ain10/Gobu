using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseLVLScript : MonoBehaviour
{
    [SerializeField] List<Button> buttons;
    private int lvl;


    private void Update()
    {
        lvl = FindObjectOfType<ScoreTrack>().GetComponent<ScoreTrack>().currentScene;
        if(lvl >= 4)
        {
            buttons[2].interactable = true;
        }
        else
        {
            buttons[2].interactable = false;
        }
        if (lvl >= 3)
        {
            buttons[1].interactable = true;
        }
        else
        {
            buttons[1].interactable = false;
        }
        if (lvl >= 2)
        {
            buttons[0].interactable = true;
        }
        else
        {
            buttons[0].interactable = false;
        }
    }
    public void openLVL1()
    {
        SceneManager.LoadScene("Level 01");
    }
    public void openLVL2()
    {
        SceneManager.LoadScene("Level 02");
    }
    public void openLVL3()
    {
        SceneManager.LoadScene("Level 03");
    }

    public void openShop()
    {
        SceneManager.LoadScene("Shop");
    }
}
