using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] float screenWidthinUnits = 16f;
    [SerializeField] float minXm = 1.3f;
    [SerializeField] float maxXm = 14.72f;
    [SerializeField] float velocityX = 2f;
    [SerializeField] float velocityY = 15f;
    float h = (float) 1.143;
    bool hasStarted = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hasStarted == false)
        {
            BallAttatch();
            LauchBall();
        }
    }

    public void LauchBall()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(velocityX, velocityY);
            hasStarted = true;

        }

    }

    public void BallAttatch()
    {
        float mousePos = Input.mousePosition.x / Screen.width * screenWidthinUnits;

        Vector2 ballPos = new Vector2(transform.position.x, h );
        ballPos.x = Mathf.Clamp(mousePos, minXm, maxXm);
        transform.position = ballPos;
    }

    public void hasstarted1()
    {
        hasStarted=false;
    }
}
