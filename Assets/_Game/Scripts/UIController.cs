using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{   

    public TMP_Text txtPontuacao, txtPontuacaoFinal, txtIniciar;
    private GameController gameController;

    private AudioController audioController;

    private Player player;

    public GameObject panelGame, panelPause, panelGameOver, panelMensagem1, panelMensagem2, panelMensagem3, panelMensagem4,
    panelMensagem5, panelMensagem6, panelMensagem7, panelMensagem8, panelMensagem9, panelMensagem10, panelMensagem11, panelMensagemFinal;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        gameController = FindObjectOfType<GameController>();
        audioController = FindObjectOfType<AudioController>();
        
    }

    // Update is called once per frame

    // Função para atualizar a pontuação
    void Update()
    {   double pontuacaoTransformada = gameController.pontuacaoPlayer / 100;
        txtPontuacao.text = pontuacaoTransformada.ToString("0") + "m";
        txtPontuacaoFinal.text = gameController.pontuacaoFinal.ToString("0");
    }
    
  
    // Função que ativa o menu de pause
    public void BotaoPause() {
        panelGame.gameObject.SetActive(false);
        panelPause.gameObject.SetActive(true);
        gameController.estaPausado = true;
        Time.timeScale = 0f;
    }

    // Função que desativa o menu de pause e volta ao jogo
     public void BotaoRetornarAoJogo() {
        panelGame.gameObject.SetActive(true);
        panelPause.gameObject.SetActive(false);
        Time.timeScale = 1f;
        gameController.estaPausado = false;
     }

    // Função que ativa o botão de voltar a menu principal
     public void BotaoVoltarMenu() {
       Time.timeScale = 1f;
       SceneManager.LoadScene("MenuPrincipal");
     }

    // Função que ativa o botão de jogar novamente
     public void BotaoJogarNovamente() {
        gameController.RecarregarCena();
     }


    // Função que ativa o botão Ok
    public void BotaoOK() {
        gameController.pontuacaoFinal += 1;
        panelGame.gameObject.SetActive(true);
        panelMensagem1.gameObject.SetActive(false);
        panelMensagem2.gameObject.SetActive(false);
        panelMensagem3.gameObject.SetActive(false);
        panelMensagem4.gameObject.SetActive(false);
        panelMensagem5.gameObject.SetActive(false);
        panelMensagem6.gameObject.SetActive(false);
        panelMensagem7.gameObject.SetActive(false);
        panelMensagem8.gameObject.SetActive(false);
        panelMensagem9.gameObject.SetActive(false);
        panelMensagem10.gameObject.SetActive(false);
        panelMensagem11.gameObject.SetActive(false);
        panelMensagemFinal.gameObject.SetActive(false);

        Time.timeScale = 1f;
        player.estaMovendo = true;
    }

}
