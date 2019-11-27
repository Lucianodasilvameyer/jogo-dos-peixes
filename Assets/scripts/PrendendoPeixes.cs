using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrendendoPeixes : MonoBehaviour
{
    Rede rede_ref;

    

    private void Awake()
    {
        rede_ref = GetComponent<Rede>();
    }

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
            Debug.Log("Prendeu");
            rede_ref.lentidao(collision.GetComponent<Player>());

        }
    }
  

}
