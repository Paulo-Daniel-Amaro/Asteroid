using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class NacAsteroid : MonoBehaviour
{
    public GameObject meteroroprefab;
    public List<Transform>poscri;
    public float timer, tpc, tpmi, tpma;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= tpc)
        {
            nasaste();
            timer = 0;
            tpc = Random.Range(tpmi,tpma);
        }
    }


    public void nasaste()
    {
        GameObject obj = Instantiate(meteroroprefab, poscri[Random.Range(0,poscri.Count)].position, this.transform.rotation);
        obj.GetComponent<Meteoro>().asteroidv(Vector3.zero);
    }
}
