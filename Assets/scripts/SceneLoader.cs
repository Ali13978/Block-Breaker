using System.Collections;
using System.Collections.Generic;
using UnityEngine;



using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    

    private void Start()
    {
        
    }
    public void Loadlevel1Scene()
    {
         SceneManager.LoadScene("Level 1");
    }
    public void LoadlevelmenuScene()
    {
         SceneManager.LoadScene("Level menu");
    }

     public void Loadlevel3Scene()
    {
         SceneManager.LoadScene("Level 3");
    }

         public void Loadlevel4Scene()
    {
         SceneManager.LoadScene("Level 4");
    }

         public void Loadlevel5Scene()
    {
         SceneManager.LoadScene("Level 5");
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

        public void Loadlevel2Scene()
    {
         SceneManager.LoadScene("Level 2");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
