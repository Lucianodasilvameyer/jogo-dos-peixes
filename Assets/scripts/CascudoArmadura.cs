using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CascudoArmadura : HabilidadesGeraisPlayer
{
    public bool ataqueDefendido = true;

    [SerializeField]
    HabilidadesGeraisInimigo habilidadesGeraisInimigo; 
    public bool armadura = true;

    private int reativarArmaduraInicial;

    [SerializeField]
    private int reativarArmaduraMax;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= reativarArmaduraInicial + reativarArmaduraMax && armadura==false)
        {
            armadura = true;
        }
    }
    /*public void Defender()
    {


        if (ataqueDefendido == true)
        {
            ataqueDefendido = false;
            Togglearmadura();
        }
        else if (ataqueDefendido == false)
        {

            habilidadesGeraisInimigo.CausarDano(this);

        }
    }
    public void Togglearmadura()
    {
        armadura = !armadura;
    }
    */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Inimigo"))
        {
            armadura = false;

        }
    }
}
