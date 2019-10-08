using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubarao : Inimigo
{
    void Start()
    {
        DefinirAlvo();
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("colidiu");

            //dentro do colisor a referencia é assim?

            var player = collision.gameObject.GetComponent<Player>();//se o peixe é filho do player ele  tem o componente player

            if(player != null)
            {
                CausarDano(player);
                Debug.Log("acertou");
            }

             
            

            //variavel temporaria para armazenar classe, caso o objeto que colidiu tenha essa classe //importante esta é a forma de fazer referencia dentro da colisão
            var cascudo = collision.gameObject.GetComponent<Cascudo>();
            //verifica se a variável não é nula
            if (cascudo != null)
            {
                //executa a função desejada
                cascudo.Defender();
            }
        }
    }
}    
           
            
              
            
            
            
                                                                                 //como existe uma herança aqui não é necessario uma referencia para usar metodos ou variaveis de outra classe?
                                                                         //quando funções são chamadas dentro de collisões não é necessario fazer referencias?
    

  

