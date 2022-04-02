using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart1 : MonoBehaviour
{
    
    bool destroyheart3 = false;// Start is called before the first frame update
    void Start()
    {
        
    }
    
    private void heart3()
    {
        if (destroyheart3==true)
        {
            Destroy(gameObject);
        }
    }
    public void heart33()
    {
        destroyheart3 = true;
    }
    // Update is called once per frame
    void Update()
    {
        heart3();
    }
}
