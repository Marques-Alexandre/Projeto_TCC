using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetorDeChao : MonoBehaviour
{
     private void OnTriggerEnter2D(Collider2D alvo) {
        
        if(alvo.tag == "Ground") {
            alvo.gameObject.SetActive(false);
        }
    }
}
