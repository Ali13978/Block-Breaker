using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hart2 : MonoBehaviour
{
    
    bool Destroyheart2 = false;// Start is called before the first frame update
    void Start()
    {
        
    }
    
    private void heart2()
    {
        if (Destroyheart2==true)
        {
            Destroy(gameObject, 0.05f);
        }
    }
    public void heart22()
    {
        Destroyheart2 = true;
    }
    // Update is called once per frame
    void Update()
    {
        heart2();
    }
}
