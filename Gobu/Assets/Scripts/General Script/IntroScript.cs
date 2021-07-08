using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class IntroScript : MonoBehaviour
{
    
    [SerializeField] Button butter;
    private int lvl;
    private void Update()
    {
        lvl = FindObjectOfType<ScoreTrack>().GetComponent<ScoreTrack>().currentScene;
        if(lvl <= 2)
        {
            butter.interactable = false;
        }
        else
        {
            butter.interactable = true;
        }
    }

    public void exitGame()
    {
        Application.Quit();
    }
    public void Continue()
    {
        SceneManager.LoadScene("ChooseLVL");
    }
    public void newGame()
    {
        SceneManager.LoadScene("");
    }
}
