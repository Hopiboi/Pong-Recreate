using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //Holder
    protected Rigidbody2D rg2D;

    public float paddleSpeed = 10f;

    private void Awake()
    {
        rg2D = GetComponent<Rigidbody2D>();
    }


}
