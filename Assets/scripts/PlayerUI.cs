using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    public bool armadura = true;

    private int reativarArmaduraInicial;

    [SerializeField]
    private int reativarArmaduraMax;

    [SerializeField]
    Tubarao tubarao_ref;

    [SerializeField]
    Cascudo cascudo_ref;

    // Start is called before the first frame update
    void Start()
    {
        tubarao_ref = gameObject.GetComponent<Tubarao>();
               

      if(Time.time>=reativarArmaduraInicial+reativarArmaduraMax && armadura == false)
      {

            cascudo_ref.ataqueDefendido = true;
            
            
      }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Togglearmadura()
    {
        armadura = !armadura;
    }

}
