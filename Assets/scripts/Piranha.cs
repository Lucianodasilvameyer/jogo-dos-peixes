using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piranha : Player
{


    public static Piranha scriptPiranha;

    SpriteRenderer spriteRenderer;

    public GameObject UmPiranha;
    public GameObject DuasPiranhas;
    public GameObject TresPiranhas;
    public GameObject QuatroPiranhas;
    public GameObject CincoPiranhas;

    // Start is called before the first frame update,
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

   

    // Update is called once per frame
    void Update()
    {
        Cardume();
    }
    public void Cardume()
    {
        

        /*if (UmPiranha.activeInHierarchy == true)
        {
            UmPiranha.SetActive(false);
            DuasPiranhas.SetActive(true);
        }
        else if (DuasPiranhas.activeInHierarchy == true)
        {
            DuasPiranhas.SetActive(false);
            TresPiranhas.SetActive(true);
        }
        else if (TresPiranhas.activeInHierarchy == true)
        {
            TresPiranhas.SetActive(false);
            QuatroPiranhas.SetActive(true);
        }
        else if (QuatroPiranhas.activeInHierarchy == true)
        {
            QuatroPiranhas.SetActive(false);
            CincoPiranhas.SetActive(true);
        }*/

    }
}
