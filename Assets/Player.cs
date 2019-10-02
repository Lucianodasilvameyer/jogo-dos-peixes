using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{

    Rigidbody2D righ;
    public float speed;

    

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
            else if(value> vidaMax)
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
}
