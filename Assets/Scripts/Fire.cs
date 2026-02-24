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
        Destroy(this.gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void piupiu(Vector2 dir)
    {
        rb2d.AddForce(dir*vel);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("asteroid"))
        {
            GameObject.FindWithTag("Player").gameObject.GetComponent<Movimentação>().pontua(collision.gameObject.GetComponent<Meteoro>().poto);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
