using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public int dashes = 0;

    public float speed;
    public float dashSpeed;


    private int direction;

    public bool recarregar = false;

    public GameObject projetilPrefab;


    Game game_ref;



    private float TempoDashInicial;

    [SerializeField]
    private float TempoDashMax;








    Rigidbody2D righ;




    bool isDead = false;

    [SerializeField]
    private int HPMax;

    [SerializeField]
    private int vidaInicial;

    [SerializeField]
    Slider sliderHp;

    [SerializeField]
    private int hp = 50;

    public int HP
    {
        get
        {
            return hp;
        }
        set
        {
            hp = value; //não deveria colocalo no else?

            if (hp <= 0)
            {
                hp = 0;

                if (sliderHp && sliderHp != null)// aqui garante q não tem referencias?
                    sliderHp.value = 0;
            }
            else if (hp >= HPMax)
            {
                hp = HPMax;

                if (sliderHp && sliderHp != null)
                    sliderHp.value = 1;

            }
            else
            {
                if (sliderHp && sliderHp != null)
                    sliderHp.value = (float)hp / (float)HPMax; //colocar como float para poder trabalhar com valores de vida com virgula futuramente?
            }

        }
    }






    // Start is called before the first frame update
    private void FixedUpdate()
    {

        Vector3 Position = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        righ.velocity = Position * speed;

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxisRaw("Vertical");


        if (Input.GetKeyDown(KeyCode.Space) && recarregar == false && dashes == 0)
        {
            Dash(x, y);
            TempoDashInicial = Time.time;
            dashes++;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && recarregar == false && dashes == 1)
        {
            Dash(x, y);
            TempoDashInicial = Time.time;
            recarregar = true;
        }
        if (Time.time >= TempoDashInicial + TempoDashMax && recarregar == true)
        {
            recarregar = false;
            dashes = 0;
        }
    }

    void Start()
    {
        //como fazer uma referencia para usar metodos de outra classe sem ser por tag e assim usando menos memoria?

        HP = 50;
        righ = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
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
}

