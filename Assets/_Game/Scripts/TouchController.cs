using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{   
    private Player player;

    private GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        gameController = FindObjectOfType<GameController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
            if (!player.estaMovendo && !gameController.estaMorto) {
                player.estaMovendo = true;
            }
            else {
                player.Pulo();
            }
        }
    }
}
