﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rede : MonoBehaviour
{
    [SerializeField]
    PlayerMovimentacao playerMovimentacao_ref;

    public float strength;

    public float recarregar;
   

    public bool devagar = false;

    private float velocidadeLentaInicial;

    [SerializeField]
    private float velocidadeLentaMax;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Time.time>= velocidadeLentaInicial+velocidadeLentaMax && devagar == true)
       {

            devagar = false;
            
            playerMovimentacao_ref.speed += (int)recarregar;

            

            
        } 
    }
    public void desacelerar(int prender)
    {
        playerMovimentacao_ref.speed -= prender;
        devagar = true;
        
    }
    public void lentidao(Player alvo)
    {
        desacelerar((int)strength);
        
    }


}
