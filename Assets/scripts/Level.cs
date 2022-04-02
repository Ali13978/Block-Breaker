using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Level : MonoBehaviour


{    
    [SerializeField] int BreakableBlocks;
    [SerializeField] int Score = 0;
    [SerializeField] int bonus = 0;
    [SerializeField] int maxscore = 0;
    int maxbonus = 6;
    public TextMeshProUGUI SCORE;
    Star3 DestroyStar3;

    void Start()
    {
        if (!PlayerPrefs.HasKey("Score"))
        {
            PlayerPrefs.SetInt("Score", 0);
        }
        if (!PlayerPrefs.HasKey("maxScore"))
        {
            PlayerPrefs.SetInt("maxScore",0);
        }
    }
    
    public void CountMaxScore()
    {
        maxscore = maxscore + maxbonus;
        PlayerPrefs.SetInt("maxScore", maxscore);

    }

    public void score()
    {
      bonus = bonus + 1;
      if(bonus>6)
      {
          bonus=6;
      }
      Score = Score + bonus;
    }


    void Update()
    {
        SCORE.text = Score.ToString();
        Congscene();
    } 
 
    public void bonus0()
    {
        bonus=0;
    }

    public void CountBreakablBlocks()
    {
        BreakableBlocks++;
    }

    public void RemainingBlocks()
    {
        BreakableBlocks = BreakableBlocks -1;
    }
    private void Congscene()
    {
        if (BreakableBlocks <= 0)
        {
            PlayerPrefs.SetInt("Score", Score);
            SceneManager.LoadScene("Cong");
        }
    }
    
}
