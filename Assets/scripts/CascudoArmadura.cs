using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CascudoArmadura : HabilidadesGeraisPlayer
{
    public bool ataqueDefendido = true;
    HabilidadesGeraisInimigo inimigo = new HabilidadesGeraisInimigo();
    public bool armadura = true;
    // Start is called before the first frame update
    void Start()
    {
        
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
            Togglearmadura();
        }
        else if (ataqueDefendido == false)
        {

            inimigo.CausarDano(this);

        }
    }
    public void Togglearmadura()
    {
        armadura = !armadura;
    }
}
