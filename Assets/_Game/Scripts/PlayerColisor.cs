using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColisor : MonoBehaviour
{
  private void OnTriggerEnter2D(Collider2D alvo) {
    
    if(alvo.gameObject.CompareTag("Obstaculo")) {
        GameController tempGameController = FindObjectOfType<GameController>();
        tempGameController.estaMorto = true;
    }
  } 


}
