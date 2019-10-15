using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolDownArmaduraCascudo : MonoBehaviour
{
    public int reativarArmaduraInicial;

    public int reativarArmaduraMax;

    [SerializeField]
    CascudoArmadura cascudoArmadura;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= reativarArmaduraInicial + reativarArmaduraMax && cascudoArmadura.armadura == false)
        {

            cascudoArmadura.ataqueDefendido = true;
        }
    }
}
