using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CenasController : MonoBehaviour
{
    public GameObject PanelSelecionarCenario;

    private AudioController audioController;

    // Start is called before the first frame update
    void Start()
    {
        audioController = FindObjectOfType<AudioController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Função que ativa o botão de escolha da Cena 01
    public void BotaoCena1() {
        SceneManager.LoadScene("Cena01");
    }

    // Função que ativa o botão de escolha da Cena 01
     public void BotaoCena2() {
        SceneManager.LoadScene("Cena02");
    }

    // Função que ativa o botão de escolha da Cena 01
    public void BotaoCena3() {
        SceneManager.LoadScene("Cena03");
    }

}
