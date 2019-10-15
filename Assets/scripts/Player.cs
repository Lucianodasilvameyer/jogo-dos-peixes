using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{

    [SerializeField]
    Interface interface_ref;

    [SerializeField]
    Game game_ref;
    

    //public bool isLambari = false;

    //Rigidbody2D righ;

    public int dashes = 0;

    //public int speed;

    //public int dashSpeed;

    // private int direction;

    // public bool recarregar = false;

    //public GameObject projetilPrefab;

    //public float TempoDashInicial;

    //public float TempoDashMax;

    // [SerializeField]
    //private int HPMax;

    //[SerializeField]
    //private int hp;// no inspector o h fica maiusculo?sim


    /*public int HP
    {
        get
        {
            return hp;
        }
        set
        {
            hp = value; 

            if (hp <= 0)
            {
                hp = 0;

                if (interface_ref.sliderHp && interface_ref.sliderHp != null)// aqui garante q não tem referencias?
                    interface_ref.sliderHp.value = 0;
            }
            else if (hp >= HPMax)
            {
                hp = HPMax;

                if (interface_ref.sliderHp && interface_ref.sliderHp != null)
                    interface_ref.sliderHp.value = 1;

            }
            else
            {
                if (interface_ref.sliderHp && interface_ref.sliderHp != null)
                    interface_ref.sliderHp.value = (float)hp / (float)HPMax; //colocar como float para poder trabalhar com valores de vida com virgula futuramente?
            }

        }
    }*/

    /*private void FixedUpdate()
    {

        Vector3 Position = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        righ.velocity = Position * speed;

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        //if (!isLambari)
        //{
            if (Input.GetKeyDown(KeyCode.Space) && recarregar == false)
            {
                Dash(x, y);
                TempoDashInicial = Time.time;
                recarregar = true;
            }

            
        //}
        
    }

    void Start()
    {
        righ = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {

    }
    public void Dash(float x, float y)
    {
        Vector2 direction = new Vector2(x, y);
        righ.AddForce(direction * dashSpeed, ForceMode2D.Impulse);//força e modo respectivamente? no caso o direction vira um vetor ao ser adicionado força a ele 
    }
    public void TomarDano(int dano)
    {
        hp -= dano;
    }
   /* public void spawnarProjetil( int distanciaInimigoPlayer)
    {
        Vector2 position = transform.position;
        position.x += distanciaInimigoPlayer;
        position.y += distanciaInimigoPlayer;

        Instantiate(projetilPrefab, position, Quaternion.identity);

    }*/
    /* public void Comer()
     {
         game_ref.Contagem += 5;
     }*/
    //public void TomarDano(int dano)
    //{
      //  hp -= dano;
    //}
}

