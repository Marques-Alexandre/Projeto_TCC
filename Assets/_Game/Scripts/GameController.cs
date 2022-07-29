using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{   
    public float pontuacaoPlayer;

    public bool inicioJogo, estaMorto;

    // Start is called before the first frame update
    void Start()
    {
        pontuacaoPlayer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(inicioJogo && !estaMorto) {
            pontuacaoPlayer += Time.deltaTime;
        }
    }
}
