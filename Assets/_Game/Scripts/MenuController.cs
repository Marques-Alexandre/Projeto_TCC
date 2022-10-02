using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject panelMenuPrincipal, panelInformacoes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
}
