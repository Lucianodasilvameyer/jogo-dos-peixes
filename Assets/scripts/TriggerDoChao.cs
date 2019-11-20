using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoChao : MonoBehaviour
{
    [SerializeField]
    ReutilizarChao reutilizarChao_ref;

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
            reutilizarChao_ref.reutilizarChao();
            Debug.Log("Funcionou");
        }
    }
}
