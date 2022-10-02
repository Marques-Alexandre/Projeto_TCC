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

    public void RecarregarCena() {
        string cena = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(cena);
    }

    public void IniciarJogo() {
       inicioJogo = true;
    }

    public void jogarNovamente() {
        player.Restart();
        inicioJogo = true;
    }

    // Função que mostrará todas as mensagens educativas do jogo
    public void MensagemEducativa() {

        if (pontuacaoPlayer == 3000) {
            uIController.panelGame.gameObject.SetActive(false);
            uIController.panelMensagem1.gameObject.SetActive(true);
            Time.timeScale = 0f;
            pontuacaoFinal += 1;
        }
        else if (pontuacaoPlayer == 10000) {
            uIController.panelGame.gameObject.SetActive(false);
            uIController.panelMensagem2.gameObject.SetActive(true);
            Time.timeScale = 0f;
            pontuacaoFinal += 1;
        }

    }


}
