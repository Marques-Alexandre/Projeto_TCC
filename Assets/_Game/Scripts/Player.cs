using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    [SerializeField] private float velocidade, forçaPulo;

    [HideInInspector] public Rigidbody2D rb;

    private Animator meuAnimator;

    public bool estaNoChao, estaMovendo;

    // Start is called before the first frame update
    void Start()
    {
        Inicializar();
    }

    // Update is called once per frame
    void Update()
    {
        if (estaMovendo) {
            transform.Translate(Vector2.right * (velocidade * Time.deltaTime), Space.World);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            Pulo();
        }
    }

    // Função para reinicializar o jogo
    public void Restart() {
        GameController gameController = FindObjectOfType<GameController>();
        if (gameController.estaMorto) {
            gameController.estaMorto = false;
            // Animação de morto false
            meuAnimator.SetBool("Morrer", false);
            Inicializar();
        }
    }

    // Função de quando o jogador morre
    public void Morto() {
        GameController gameController = FindObjectOfType<GameController>();
        if (gameController.estaMorto) {
            estaMovendo = false;
            // Animação de morto true
            meuAnimator.SetBool("Morrer", true);
            // Animação de correr false
            meuAnimator.SetBool("Correr", false);

        }
    }

    // Função de quando o jogo é inicializado
    public void Inicializar() {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        meuAnimator = this.gameObject.GetComponent<Animator>();
        estaNoChao = true;
        estaMovendo = false;
        
        GameController gameController = FindObjectOfType<GameController>();
        gameController.estaMorto = false;


        InvokeRepeating("EstaNoChao", 0.1f, 0.1f);
        InvokeRepeating("Correr", 0.1f, 0.1f);
        InvokeRepeating("Morto", 0.1f, 0.1f);
    }

    // Função para fazer o jogador correr
    private void Correr() {
        if (estaMovendo) {
            // Animação de correr true
            meuAnimator.SetBool("Correr", true);
            GameController gameController = FindObjectOfType<GameController>();
            gameController.inicioJogo = true;
            return;
        }
    }
    // Função para fazer o jogador pular
    public void Pulo() {
        if(rb.velocity.y == 0 && estaMovendo) {
            rb.AddForce(transform.up * forçaPulo);
            estaNoChao = false;
            // Animação do pulo true
            meuAnimator.SetBool("Pular", true);
        }
    }

    // Função para fazer o jogador estar no chão
    private void EstaNoChao() {
       if(rb.velocity.y == 0 && !estaNoChao) {
           estaNoChao = true;
           // Animação de Pulo false
           meuAnimator.SetBool("Pular", false);
       }
    }

}
