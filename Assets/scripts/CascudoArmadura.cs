using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CascudoArmadura : MonoBehaviour
{

   
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
   
   
}
