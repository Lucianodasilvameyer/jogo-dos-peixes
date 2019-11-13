using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtacandoCascudo : MonoBehaviour
{
    Cascudo cascudo; //??

    [SerializeField]
    CascudoArmadura cascudoArmadura_ref;

    [SerializeField]
    HabilidadesGeraisInimigo habilidadesGeraisInimigo_ref;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cascudo"))
        {
            if (cascudoArmadura_ref.armadura == true)
            {
                cascudoArmadura_ref.armadura = false;
                Debug.Log("acertou");
            }
            else if(cascudoArmadura_ref.armadura == false)
            {
                habilidadesGeraisInimigo_ref.CausarDano(cascudo);
            }
            
        }
    }
}
/*if (cascudoArmadura_ref.armadura == false)
            {
                var player = collision.gameObject.GetComponent<Cascudo>();

                if (player != null)
                {
                    habilidadesGeraisInimigo_ref.CausarDano(cascudo);
                    Debug.Log("acertou");
                }

            }*/



/*Debug.Log("colidiu");

           var player = collision.gameObject.GetComponent<Player>();//se o peixe é filho do player ele  tem o componente player
                                                                    //aqui em cima salva o gameObject com o componente player na variavel temporaria var player
           if (player != null)
           {
               CausarDano(player);
               Debug.Log("acertou");
           }*/


//variavel temporaria para armazenar classe, caso o objeto que colidiu tenha essa classe //importante esta é a forma de fazer referencia dentro da colisão
//var cascudo = collision.gameObject.GetComponent<Cascudo>();
//verifica se a variável não é nula
//if (cascudo != null)

//executa a função desejada
//    cascudo.Defender();






//como existe uma herança aqui não é necessario uma referencia para usar metodos ou variaveis de outra classe?
//quando funções são chamadas dentro de collisões não é necessario fazer referencias?
