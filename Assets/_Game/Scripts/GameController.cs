using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{   
    public double pontuacaoPlayer, pontuacaoFinal;

    public bool inicioJogo, estaMorto, estaPausado;

    public UIController uIController;

    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        pontuacaoPlayer = 0f;
        pontuacaoFinal = 0f;
        uIController = FindObjectOfType<UIController>();
        player = FindObjectOfType<Player>();

    }

    // Update is called once per frame
    void Update()
    {
        IniciarJogo();

        if(player.estaMovendo && !estaMorto && !estaPausado) {
            pontuacaoPlayer += 1f;
        } if (estaMorto) {
            uIController.panelGameOver.gameObject.SetActive(true);
            uIController.panelGame.gameObject.SetActive(false);
            inicioJogo = false;
        }

        MensagemEducativa();
        
    }

    // Função para recarregar a cena atual do jogo
    public void RecarregarCena() {
        string cena = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(cena);
    }


    // Função para iniciar o jogo
    public void IniciarJogo() {
       inicioJogo = true;
    }

    // Função que mostrará todos os desafios do jogo.
    public void MensagemEducativa() {

        if (pontuacaoPlayer == 2000) {
            uIController.panelGame.gameObject.SetActive(false);
            uIController.panelMensagem1.gameObject.SetActive(true);
            Time.timeScale = 0f;
            player.estaMovendo = false;
        }
        else if (pontuacaoPlayer == 10000) {
            uIController.panelGame.gameObject.SetActive(false);
            uIController.panelMensagem2.gameObject.SetActive(true);
            Time.timeScale = 0f;
            player.estaMovendo = false;
        }
        else if (pontuacaoPlayer == 16000) {
            uIController.panelGame.gameObject.SetActive(false);
            uIController.panelMensagem3.gameObject.SetActive(true);
            Time.timeScale = 0f;
            player.estaMovendo = false;
        }
        else if (pontuacaoPlayer == 24000) {
            uIController.panelGame.gameObject.SetActive(false);
            uIController.panelMensagem4.gameObject.SetActive(true);
            Time.timeScale = 0f;
            player.estaMovendo = false;
        }
         else if (pontuacaoPlayer == 31000) {
            uIController.panelGame.gameObject.SetActive(false);
            uIController.panelMensagem5.gameObject.SetActive(true);
            Time.timeScale = 0f;
            player.estaMovendo = false;
        }
         else if (pontuacaoPlayer == 42000) {
            uIController.panelGame.gameObject.SetActive(false);
            uIController.panelMensagem6.gameObject.SetActive(true);
            Time.timeScale = 0f;
            player.estaMovendo = false;
        }
         else if (pontuacaoPlayer == 53000) {
            uIController.panelGame.gameObject.SetActive(false);
            uIController.panelMensagem7.gameObject.SetActive(true);
            Time.timeScale = 0f;
            player.estaMovendo = false;
        }
         else if (pontuacaoPlayer == 61000) {
            uIController.panelGame.gameObject.SetActive(false);
            uIController.panelMensagem8.gameObject.SetActive(true);
            Time.timeScale = 0f;
            player.estaMovendo = false;
        }
         else if (pontuacaoPlayer == 80000) {
            uIController.panelGame.gameObject.SetActive(false);
            uIController.panelMensagem9.gameObject.SetActive(true);
            Time.timeScale = 0f;
            player.estaMovendo = false;
        }
         else if (pontuacaoPlayer == 102000) {
            uIController.panelGame.gameObject.SetActive(false);
            uIController.panelMensagem10.gameObject.SetActive(true);
            Time.timeScale = 0f;
            player.estaMovendo = false;
        }
         else if (pontuacaoPlayer == 200000) {
            uIController.panelGame.gameObject.SetActive(false);
            uIController.panelMensagem11.gameObject.SetActive(true);
            Time.timeScale = 0f;
            player.estaMovendo = false;
        }
            else if (pontuacaoPlayer == 220000) {
            uIController.panelGame.gameObject.SetActive(false);
            uIController.panelMensagemFinal.gameObject.SetActive(true);
            Time.timeScale = 0f;
            player.estaMovendo = false;
        }

    }


}
