using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject panelMenuPrincipal, panelInformacoes;


    // Função que ativa o botão de jogar, para escolher o cenário do jogo
    public void BotaoJogar() {
        SceneManager.LoadScene("SeleçãoCenários");
    }

    // Função que ativa o botão de Informações
    public void BotaoInformacoes() {
       panelInformacoes.gameObject.SetActive(true);
    }

    // Função que ativa o botão de voltar ao Menu no painel de Informações
    public void BotaoVoltarMenuInformacoes() {
        panelInformacoes.gameObject.SetActive(false);
    }

      // Função que ativa o botão de sair do jogo
    public void BotaoSair() {
        AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
        activity.Call<bool>("moveTaskToBack", true);
    }
}
