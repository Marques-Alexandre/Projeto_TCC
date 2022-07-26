using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAdapter : MonoBehaviour
{

    [SerializeField] private SpriteRenderer [] spritesRenderer;    

    // Função para adaptar o background para o tamanho da tela
    private void Awake() {
        float tempTransform = spritesRenderer[0].sprite.bounds.size.x;

        for (int i = 0; i < spritesRenderer.Length; i++) {
                spritesRenderer[i].transform.position = new Vector2(tempTransform * i, transform.position.y);
        }
    }
}
