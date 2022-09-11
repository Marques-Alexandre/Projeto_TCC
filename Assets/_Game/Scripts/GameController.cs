using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{   
    public double pontuacaoPlayer;

    public bool inicioJogo, estaMorto;

    public UIController uIController;

    // Start is called before the first frame update
    void Start()
    {
        pontuacaoPlayer = 0f;
        uIController = FindObjectOfType<UIController>();

    }

    // Update is called once per frame
    void Update()
    {
        if(inicioJogo && !estaMorto) {
            pontuacaoPlayer += 1f;
        }

        MensagemEducativa();

    }

    // Função que mostrará todas as mensagens educativas do jogo
    public void MensagemEducativa() {

        if (pontuacaoPlayer == 3000) {
            uIController.panelGame.gameObject.SetActive(false);
            uIController.panelMensagem1.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (pontuacaoPlayer == 10000) {
            uIController.panelGame.gameObject.SetActive(false);
            uIController.panelMensagem2.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
