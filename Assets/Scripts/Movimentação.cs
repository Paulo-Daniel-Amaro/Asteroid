using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Movimentação : MonoBehaviour
{ 
    public float eixoX, eixoY, velo, velanda, limitrot;
    public Vector2 eixoPos;
    public Rigidbody2D rb2d;
    public int vida;
    public GameObject fire;
    public Transform posfire;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            thiuthiu();
        }
        eixoX = Input.GetAxis("Horizontal") * -1;
        rb2d.AddTorque(eixoX * velo);
        if (Input.GetKey(KeyCode.W))
            {
            eixoY = 1;
        }
        else
        {
            eixoY = 0;
        }
        eixoPos = this.transform.up*eixoY*velanda;
        rb2d.velocity = eixoPos;
        if(rb2d.angularVelocity<= -limitrot)
        {
            rb2d.angularVelocity = -limitrot;
        }
        else if (rb2d.angularVelocity>= limitrot) { 
        rb2d.angularVelocity= limitrot;
        }
    }
    public void thiuthiu()
    {
      GameObject obj =  Instantiate(fire, posfire.position, this.transform.rotation);
        obj.GetComponent<Fire>().piupiu(this.transform.up);
    }

  
}
