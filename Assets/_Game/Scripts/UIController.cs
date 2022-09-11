using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{   

    public TMP_Text txtPontuacao;
    private GameController gameController;

    public GameObject panelGame, panelPause, panelMensagem1, panelMensagem2;

    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    // Update is called once per frame

    // Função para atualizar a pontuação
    void Update()
    {
        txtPontuacao.text = gameController.pontuacaoPlayer.ToString("0") + "m";
    }
    
    // Função que ativa o menu de pause
    public void BotaoPause() {
        panelGame.gameObject.SetActive(false);
        panelPause.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    // Função que desativa o menu de pause e volta ao jogo
     public void BotaoRetornarAoJogo() {
        panelGame.gameObject.SetActive(true);
        panelPause.gameObject.SetActive(false);
        Time.timeScale = 1f;
     }

     //public void BotaoVoltarMenu() {
       // panelPause.gameObject.SetActive(false);
       // panelMenuPrincipal.gameObject.SetActive(true);
       // panelGameOver.gameObject.SetActive(false);
       //Time.timeScale = 1f;

    // }


    public void BotaoOK() {
        panelGame.gameObject.SetActive(true);
        panelMensagem1.gameObject.SetActive(false);
        panelMensagem2.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
}
