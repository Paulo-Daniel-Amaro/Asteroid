using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteoro : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float vel;
    public int dano;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void asteroidv(Vector3 dire)
    {
        Vector3 dir = dire - this.gameObject.transform.position ;
        rb2d.velocity = dir * vel;
    }
}
