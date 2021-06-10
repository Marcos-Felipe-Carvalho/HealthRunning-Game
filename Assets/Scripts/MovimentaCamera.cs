using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentaCamera : MonoBehaviour
{
    public float velocidadeDaCamera;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(velocidadeDaCamera * Time.deltaTime, 0, 0);
    }
}
