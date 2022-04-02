using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LooseCollider : MonoBehaviour
{   [SerializeField] int lives=3;
    Ball Lives;
    heartsa hjk;
    hart2 ghj;
    heart1 yfu;

    public void OnTriggerEnter2D(Collider2D collision)
    {   
        lives = lives -1;
        Lives=GameObject.FindGameObjectWithTag("balls").GetComponent<Ball>();
        Lives.hasstarted1();
        if(lives==2)
        {
           hjk=GameObject.FindGameObjectWithTag("hjkkfg").GetComponent<heartsa>();
           hjk.heart11();
        }
        if(lives==1)
        {
           ghj=GameObject.FindGameObjectWithTag("DESTROYHEART2").GetComponent<hart2>();
           ghj.heart22();
        }
        if (lives == 0)
        {
            yfu=GameObject.FindGameObjectWithTag("DESTROYHEART3").GetComponent<heart1>();
            yfu.heart33();
            SceneManager.LoadScene("Game Over");
        }
    }

}
