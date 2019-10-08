using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lambari : Player
{
    // Start is called before the first frame update
    
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
        Doubledash();
    }
    public void Doubledash()
    {
        if (Player.scripPlayer.isLambari == true)
        {
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
        
    }
}
