using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{   
    private Player player;

    private GameController gameController;

    private UIController uIController;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        gameController = FindObjectOfType<GameController>();
        uIController = FindObjectOfType<UIController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && gameController.inicioJogo) {
           if (!player.estaMovendo && !gameController.estaMorto) {
               player.estaMovendo = true;
               uIController.txtIniciar.gameObject.SetActive(false);
           }
            else {
            player.Pulo();
            }
        }
    }

}
