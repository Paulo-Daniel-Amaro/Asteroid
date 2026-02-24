using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimentação : MonoBehaviour
{ 
    public float eixoX, eixoY, velo, velanda, limitrot;
    public Vector2 eixoPos;
    public Rigidbody2D rb2d;
    public int vida, pontos;
    public GameObject fire;
    public Transform posfire;
    public TextMeshProUGUI show, Ponto;

    // Start is called before the first frame update
    void Start()
    {
        show.text = "Vida : " + vida;
        Ponto.text = "Ponto : " + pontos;
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

    public void tomadano(int dano)
    {
        vida = vida - dano;
        show.text = "Vida : " + vida;
        if (vida <= 0) {
            SceneManager.LoadScene("SampleScene");
}
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("asteroid"))
        {
            tomadano(collision.gameObject.GetComponent<Meteoro>().dano);
        }
    }
    public void pontua(int ponto)
    {
        pontos = pontos + ponto;
        Ponto.text = "Ponto : " + pontos;
    }
}
