using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lambari : Player
{
    // Start is called before the first frame update
    Rigidbody2D righ;

    [SerializeField]
    PlayerUI playerUI_ref;

    [SerializeField]
    Game game_ref;


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
        HP = 50;//não é necessario setar o valor aqui?
        righ = GetComponent<Rigidbody2D>();

        playerUI_ref = gameObject.GetComponent<PlayerUI>();
        game_ref = gameObject.GetComponent<Game>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
