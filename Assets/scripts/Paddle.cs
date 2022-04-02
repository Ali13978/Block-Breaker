using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthinUnits = 16f;
    [SerializeField] float minX = 1.3f;
    [SerializeField] float maxX = 14.72f;
    Level BONUS0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePos = Input.mousePosition.x / Screen.width * screenWidthinUnits;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePos, minX, maxX );
        transform.position = paddlePos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        BONUS0=GameObject.FindGameObjectWithTag("Levels").GetComponent<Level>();
        BONUS0.bonus0();
        GetComponent<AudioSource>().Play();
    }
}
