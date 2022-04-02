using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Destroy : MonoBehaviour
{
    Level blo;
    Level level ;
    Level SCore;
    Level MAXSCORE;
    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountBreakablBlocks();

        MAXSCORE = GameObject.FindGameObjectWithTag("Levels").GetComponent<Level>();
        MAXSCORE.CountMaxScore();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SCore=GameObject.FindGameObjectWithTag("Levels").GetComponent<Level>();
        SCore.score();
        
        
        GetComponent<AudioSource>().Play();
        blo=GameObject.FindGameObjectWithTag("Levels").GetComponent<Level>();
        blo.RemainingBlocks();
       
        Destroy(gameObject, 0.05f);
        
    }

}