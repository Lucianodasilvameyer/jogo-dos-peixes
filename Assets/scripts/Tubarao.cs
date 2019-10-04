using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubarao : Inimigo
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mover(); 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Inimigo"))
        {
            CausarDano(collision.GetComponent<Player>());                        //como existe uma herança aqui não é necessario uma referencia para usar metodos ou variaveis de outra classe?
        }                                                                        //quando funções são chamadas dentro de collisões não é necessario fazer referencias?
    }
}
