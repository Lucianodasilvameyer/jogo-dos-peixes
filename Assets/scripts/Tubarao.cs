using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubarao : HabilidadesGeraisInimigo
{
    [SerializeField]
    CascudoArmadura cascudoArmadura_ref;

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
        if (collision.gameObject.CompareTag("Cascudo"))
        {
            if (cascudoArmadura_ref.armadura == false)
            {
                var player = collision.gameObject.GetComponent<Cascudo>();

                if (player != null)
                {
                    //CausarDano();
                    Debug.Log("acertou");
                }
                
            }
            /*Debug.Log("colidiu");

            var player = collision.gameObject.GetComponent<Player>();//se o peixe é filho do player ele  tem o componente player
                                                                     //aqui em cima salva o gameObject com o componente player na variavel temporaria var player
            if (player != null)
            {
                CausarDano(player);
                Debug.Log("acertou");
            }*/        
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            var cascudo = collision.gameObject.GetComponent<Cascudo>();

            
            
             
            
        }
    }
}

//variavel temporaria para armazenar classe, caso o objeto que colidiu tenha essa classe //importante esta é a forma de fazer referencia dentro da colisão
//var cascudo = collision.gameObject.GetComponent<Cascudo>();
//verifica se a variável não é nula
//if (cascudo != null)

//executa a função desejada
//    cascudo.Defender();






//como existe uma herança aqui não é necessario uma referencia para usar metodos ou variaveis de outra classe?
//quando funções são chamadas dentro de collisões não é necessario fazer referencias?




