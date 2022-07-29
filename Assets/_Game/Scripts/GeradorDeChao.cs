using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeChao : MonoBehaviour
{
   [SerializeField] private GameObject[] chaos;

   [SerializeField] private float ultimoX;

    void Start() {

        PegarChaoEDefinirUltimoX();
   }

   private void PegarChaoEDefinirUltimoX() {

        chaos = GameObject.FindGameObjectsWithTag("Ground");

        ultimoX = chaos[0].transform.position.x;

        for(int i = 1; i < chaos.Length; i++) {
            if(ultimoX < chaos[i].transform.position.x) {
                ultimoX = chaos[i].transform.position.x;
            }
        }
   }

   private void OnTriggerEnter2D(Collider2D alvo) {
        if(alvo.tag == "Ground") {
            if(alvo.transform.position.x == ultimoX) {
                Vector3 temp = alvo.transform.position;
                float altura = alvo.GetComponent<BoxCollider2D>().size.x;

                for (int i = 0; i < chaos.Length; i++)
                {
                    if(!chaos[i].activeInHierarchy) {
                        temp.x += altura;
                        ultimoX = temp.x;
                        chaos[i].transform.position = temp;
                        chaos[i].SetActive(true);
                    }
                } 
            }
        }
   }
}
