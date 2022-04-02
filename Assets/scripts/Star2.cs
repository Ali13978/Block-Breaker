using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star2 : MonoBehaviour
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
    public void Destor2()
    {
        m = true;
    }
}
