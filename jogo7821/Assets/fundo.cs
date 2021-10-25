using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fundo : MonoBehaviour
{
    private float alturatela;
    private float larguratela;
    // Start is called before the first frame update
    void Start()
    {
        alturatela = Camera.main.orthographicSize * 2;
        larguratela = alturatela / Screen.height * Screen.width;

        SpriteRenderer imagem = GetComponent<SpriteRenderer>();
        float alturaimagem = imagem.sprite.bounds.size.y;
        float larguraimagem = imagem.sprite.bounds.size.y;

        Vector2 escala = transform.localScale;
        escala.x = larguratela / larguraimagem;
        escala.y = alturatela / alturaimagem;
        this.transform.localScale = escala;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
