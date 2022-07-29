using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetorDeChao : MonoBehaviour
{   
    // Função que detecta se o chão foi coletado
     private void OnTriggerEnter2D(Collider2D alvo) {
        
        if(alvo.tag == "Ground") {
            alvo.gameObject.SetActive(false);
        }
    }
}
