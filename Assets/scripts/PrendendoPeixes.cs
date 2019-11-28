using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrendendoPeixes : MonoBehaviour
{
    CapturaDePeixe capturaDePeixe_ref;

   

    private void Awake()
    {
        capturaDePeixe_ref = GetComponent<CapturaDePeixe>();
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
        Debug.Log("Prendeu");
        capturaDePeixe_ref.lentidao(collision.GetComponent<Player>());
        
    }



}
