using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CascudoArmadura : MonoBehaviour
{

   
    public bool armadura = true;

    

    private float reativarArmaduraInicial;

    [SerializeField]
    private float reativarArmaduraMax;

    
    public bool intervaloDeColisao=false;

    private float reativarArmaduraInicialsegunda;

    [SerializeField]
    private float reativarArmaduraMaxsegunda;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


        if (Time.time >= reativarArmaduraInicial + reativarArmaduraMax && armadura == true && intervaloDeColisao==true)
        {


            reativarArmaduraInicial = Time.time;
            intervaloDeColisao = false;
            armadura = false;


        }
        if(Time.time>= reativarArmaduraInicialsegunda + reativarArmaduraMaxsegunda && armadura == false && intervaloDeColisao==false)
        {
            
            reativarArmaduraInicialsegunda = Time.time;
            armadura = true;
        }
    }
   
   
}
