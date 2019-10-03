using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public int dashes=0;

    public float speed;
    public float dashSpeed;


    private int direction;

    public bool recarregar = false;



    



    private float TempoDashInicial;

    [SerializeField]
    private float TempoDashMax;








    Rigidbody2D righ;




    bool isDead = false;

    [SerializeField]
    private int vidaMax;

    [SerializeField]
    private int vidaInicial;

    public Slider slider_;

    [SerializeField]
    private int vida;

    public int Vida
    {
        get
        {
            return Vida;
        }
        set
        {
            if (value <= 0)
            {
                vida = 0;
            }
            else if (value > vidaMax)
            {
                vida = vidaMax;
            }
            else
            {
                value = vida;
                slider_.value = (float)vida / (float)vidaMax;

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
        

        if (Input.GetKeyDown(KeyCode.Space) && recarregar == false && dashes==0)
        {
           Dash(x, y);
           TempoDashInicial = Time.time;
           dashes++;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && recarregar == false && dashes == 1)
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
        Vida = vidaInicial;
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
}

