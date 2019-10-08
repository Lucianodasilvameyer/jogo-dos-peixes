using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cascudo : Player
{
    public static Cascudo scriptCascudo;

    public bool armadura = true;

    public bool ataqueDefendido = true;

    public int reativarArmaduraInicial;

    public int reativarArmaduraMax;



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

            Inimigo.scriptInimigo.CausarDano(this);

        }
    }
    public void Togglearmadura()
    {
        armadura = !armadura;
    }
}
