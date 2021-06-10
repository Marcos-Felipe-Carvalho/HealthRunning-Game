using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float velocidadePlanoDeFundo;
    public Renderer renderizacaoPlanoDeFundo;

    // Update is called once per frame
    void Update()
    {
        renderizacaoPlanoDeFundo.material.mainTextureOffset += new Vector2(velocidadePlanoDeFundo * Time.deltaTime, 0f);    
    }
}
