using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnBreakableBlocks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
