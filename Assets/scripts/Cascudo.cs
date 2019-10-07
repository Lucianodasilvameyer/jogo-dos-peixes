using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cascudo : Player
{
    public bool ataqueDefendido = true;

    [SerializeField]
    PlayerUI playerUI_ref;

    [SerializeField]
    Inimigo inimigo_ref;

    // Start is called before the first frame update
    void Start()
    {
        playerUI_ref = gameObject.GetComponent<PlayerUI>();
        inimigo_ref = gameObject.GetComponent<Inimigo>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Defender()
    {
        if (ataqueDefendido == true)
        {
            ataqueDefendido = false;
            playerUI_ref.Togglearmadura();
        }
        else if (ataqueDefendido == false)
        {

            inimigo_ref.CausarDano(this);

        }
    }
}
