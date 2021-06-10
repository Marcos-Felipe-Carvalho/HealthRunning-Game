using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    public GameObject obstaculo;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float tempo;
    public float tempoObstaculo;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > tempoObstaculo)
        {
            Spawn();
            tempoObstaculo = Time.time + tempo;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstaculo, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
