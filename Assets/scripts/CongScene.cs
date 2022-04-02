using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CongScene : MonoBehaviour
{
    Star3 DestroyStar3;
    Star2 DestroyStar2;

    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = PlayerPrefs.GetInt("Score").ToString();
        Star3();
        Star2();
    }

    public void Star3 ()
    {
        if (PlayerPrefs.GetInt("Score") < (PlayerPrefs.GetInt("maxScore") / 1.5f))
        {
            DestroyStar3 = GameObject.FindGameObjectWithTag("DESTROYSTAR#").GetComponent<Star3>();
            DestroyStar3.Destor3();
        }
    }

    public void Star2()
    {
        if (PlayerPrefs.GetInt("Score") < (PlayerPrefs.GetInt("maxScore") / 1.8f))
        {
            DestroyStar2 = GameObject.FindGameObjectWithTag("DESTROYSTAR@").GetComponent<Star2>();
            DestroyStar2.Destor2();
        }
    }

}
