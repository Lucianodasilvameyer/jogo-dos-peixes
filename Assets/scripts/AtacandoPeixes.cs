using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtacandoPeixes : MonoBehaviour
{
    
    
    [SerializeField]
    HabilidadesGeraisInimigo habilidadesGeraisInimigo_ref;


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
        if (collision.gameObject.CompareTag("Player"))
        {

            habilidadesGeraisInimigo_ref.CausarDano(collision.GetComponent<Player>());

            
        }
    }
}
