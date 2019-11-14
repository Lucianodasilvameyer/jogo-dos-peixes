using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class LambariDoubleDash : HabilidadesGeraisPlayer
  

    // Start is called before the first frame update
    [SerializeField]
    CoolDownDoubleDash DownDoubleDash;

    [SerializeField]
    PlayerDash playerDash_ref;

    public int dashes = 0;

    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        Doubledash();
        Debug.Log(DownDoubleDash.recarregar);
        Debug.Log(dashes);
    }


    public void Doubledash()
    {
        
        
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxisRaw("Vertical");
            if (Input.GetKeyDown(KeyCode.Space) && DownDoubleDash.recarregar == false && dashes == 0)
            {
                playerDash_ref.Dash(x, y);
                DownDoubleDash.TempoDashInicial = Time.time;
                dashes++;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && DownDoubleDash.recarregar == false && dashes == 1)
            {
                playerDash_ref.Dash(x, y);
                DownDoubleDash.TempoDashInicial = Time.time;
                DownDoubleDash.recarregar = true;
            }
            if (Time.time >= DownDoubleDash.TempoDashInicial + DownDoubleDash.TempoDashMax && DownDoubleDash.recarregar == true)
            {
                DownDoubleDash.recarregar = false;
                dashes = 0;

            }
        

    }
}*/