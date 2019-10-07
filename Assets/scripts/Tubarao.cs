using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubarao : Inimigo
{
  



    // Start is called before the first frame update
    void Start()
    {
         //só com o PlayerUI playerUI_ref eu consigo invocar variareis de outro script, com o playerUI_ref = GetComponent<PlayerUI>() e arrastando a referencia para o inspector eu poderia invocar metodos? 


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
        {                                                    //importante esta é a forma de 
            //variavel temporaria para armazenar classe, caso o objeto que colidiu tenha essa classe
            var cascudo = collision.gameObject.GetComponent<Cascudo>();
            //verifica se a variável não é nula
            if(cascudo != null)
            {
                //executa a função desejada
                cascudo.Defender(); 
            }

            
            /*Debug.Log("acertou");
            if (ataqueDefendido == true)
            {
                ataqueDefendido = false;
                playerUI_ref.Togglearmadura();
            }
            else if (ataqueDefendido == false)
            {
                
                CausarDano(collision.GetComponent<Player>());
                
            }*/
            
              
            
            
            
                                                                                 //como existe uma herança aqui não é necessario uma referencia para usar metodos ou variaveis de outra classe?
        }                                                                        //quando funções são chamadas dentro de collisões não é necessario fazer referencias?
    }

  
}
