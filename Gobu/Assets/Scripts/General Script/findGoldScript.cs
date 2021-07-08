using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class findGoldScript : MonoBehaviour
{
    private int score;
    [SerializeField] List<Text> WeaponArmor;

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<ScoreTrack>())
        {
            gameObject.GetComponent<UnityEngine.UI.Text>().text = FindObjectOfType<ScoreTrack>().GetComponent<ScoreTrack>().gameGold.ToString();
            WeaponArmor[0].GetComponent<UnityEngine.UI.Text>().text = FindObjectOfType<ScoreTrack>().GetComponent<ScoreTrack>().weaponUpgrade.ToString();
            WeaponArmor[1].GetComponent<UnityEngine.UI.Text>().text = FindObjectOfType<ScoreTrack>().GetComponent<ScoreTrack>().healthUpgrade.ToString();
        }
        
    }
}
