using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{   

    public TMP_Text txtPontuacao;
    private GameController gameController;

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
}
