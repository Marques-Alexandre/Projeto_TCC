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

    public GameObject panelGame, panelPause, panelGameOver, panelMensagem1, panelMensagem2;

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
    {
        txtPontuacao.text = gameController.pontuacaoPlayer.ToString("0.0") + "m";
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
        panelGame.gameObject.SetActive(true);
        panelMensagem1.gameObject.SetActive(false);
        panelMensagem2.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    // Função que ativa o botão de sair do jogo
    public void BotaoSair() {
        
        AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
        activity.Call<bool>("moveTaskToBack", true);
    }
}
