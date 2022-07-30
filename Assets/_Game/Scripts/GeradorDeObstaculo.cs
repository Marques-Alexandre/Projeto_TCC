using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculo : MonoBehaviour
{   

    [SerializeField] private GameObject obstaculo, obstaculoCogumelo;

    [SerializeField] private Transform pontoDeGeração;

    // Start is called before the first frame update
    void Start()
    {
        GerarObstaculoAleatorio();
    }

    private void GerarObstaculoAleatorio() {
        
        int numeroAleatorio = Random.Range(1, 11);

        if(numeroAleatorio <= 6 || numeroAleatorio <= 5) {
           GameObject tempPrefab = Instantiate(obstaculo,pontoDeGeração.position, Quaternion.identity) as GameObject;
           //GameObject tempPrefabCogumelo = Instantiate(obstaculoCogumelo, pontoDeGeração.position, Quaternion.identity) as GameObject;
           tempPrefab.transform.parent = pontoDeGeração.transform;
           //tempPrefabCogumelo.transform.parent = pontoDeGeração.transform;

        } else if (numeroAleatorio > 6 || numeroAleatorio <= 5) {
            GameObject tempPrefab = Instantiate(obstaculoCogumelo, pontoDeGeração.position, Quaternion.identity) as GameObject;
            tempPrefab.transform.parent = pontoDeGeração.transform;
        }
    }



}
