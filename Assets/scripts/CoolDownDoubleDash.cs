using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolDownDoubleDash : MonoBehaviour
{
    public bool recarregar = false;

    public float TempoDashInicial;

    public float TempoDashMax;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= TempoDashInicial + TempoDashMax && recarregar == true)
        {
            recarregar = false;
        }
    }
}
