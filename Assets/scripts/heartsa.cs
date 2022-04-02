using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartsa : MonoBehaviour
{
    bool asd = false;// Start is called before the first frame update
    void Start()
    {
        
    }
    
    private void heart1()
    {
        if (asd==true)
        {
            Destroy(gameObject, 0.05f);
        }
    }
    public void heart11()
    {
        asd = true;
    }

    // Update is called once per frame
    void Update()
    {
        heart1();
    }

}
