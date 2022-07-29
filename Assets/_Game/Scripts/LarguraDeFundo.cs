using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LarguraDeFundo : MonoBehaviour
{

    private SpriteRenderer sprite;

    private void Awake() {
        sprite = this.gameObject.GetComponent<SpriteRenderer>();
    }
    // Start is called before th first frame update

    // Função para adaptar a largura do background para o tamanho da tela, assim que o jogo é inicializado
    void Start()
    {
        Vector3 escalaTemp = transform.localScale;

        float largura = sprite.bounds.size.x;
        float altura = sprite.bounds.size.y;

        float alturaWorld = Camera.main.orthographicSize * 2f;
        float larguraWorld = alturaWorld / Screen.height * Screen.width;

        escalaTemp.x = larguraWorld / largura;

        transform.localScale = escalaTemp;
    }

 
}
