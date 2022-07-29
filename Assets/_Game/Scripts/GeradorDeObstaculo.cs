using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculo : MonoBehaviour
{   

    [SerializeField] private GameObject obstaculo;

    [SerializeField] private Transform pontoDeGeração;

    // Start is called before the first frame update
    void Start()
    {
        GerarObstaculoAleatorio();
    }

    private void GerarObstaculoAleatorio() {
        
        int numeroAleatorio = Random.Range(1, 11);

        if(numeroAleatorio <= 5) {
           GameObject tempPrefab = Instantiate(obstaculo, pontoDeGeração.position, Quaternion.identity) as GameObject;
           tempPrefab.transform.parent = pontoDeGeração.transform;
        }
    }
}
