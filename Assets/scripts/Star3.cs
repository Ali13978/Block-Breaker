using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star3 : MonoBehaviour
{
    bool m = false;
    // Start is called before the first frame update
    void Start()
    {
        if (m == true)
        {
            Destroy(gameObject);
        }


    }
   public void Destor3()
   {
        m = true;    
   }
}
