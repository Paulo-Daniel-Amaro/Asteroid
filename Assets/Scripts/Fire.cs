using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public int dano;
    public float vel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void piupiu(Vector2 dir)
    {
        rb2d.AddForce(dir*vel);
    }
}
