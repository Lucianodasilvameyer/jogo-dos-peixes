using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiranhaCardume : MonoBehaviour
{

    //public Sprite sprites;
    public GameObject UmaPiranha;
    public GameObject DuasPiranhas;
    public GameObject TresPiranhas;
    public GameObject QuatroPiranhas;
    public GameObject CincoPiranhas;

    public int cardume = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PowerUp"))
        {
            cardume++;

            if (cardume == 1)
            {
                UmaPiranha.SetActive(false);
                DuasPiranhas.SetActive(true);
            }
            else if (cardume == 2)
            {
                DuasPiranhas.SetActive(false);
                TresPiranhas.SetActive(true);
            }
            else if (cardume == 3)
            {
                TresPiranhas.SetActive(false);
                QuatroPiranhas.SetActive(true);

            }
            else if (cardume == 4)
            {
                QuatroPiranhas.SetActive(false);
                CincoPiranhas.SetActive(true);
            }
                 
        }
    }
}
