using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReutilizarTeto : MonoBehaviour
{
    ReutilizarChao reutilizarChao_ref;

    public GameObject Tetoprefab;

    [SerializeField]
    Vector2 proximaPosicaoTeto;

    Queue<GameObject> PoolTeto = new Queue<GameObject>();


    private void Awake()
    {
        reutilizarChao_ref = GetComponent<ReutilizarChao>();
    }

    // Start is called before the first frame update
    void Start()
    {
       for(int i=0; i < reutilizarChao_ref.numeroMaxPool; i++)
       {
            GameObject go = Instantiate(Tetoprefab, proximaPosicaoTeto, Quaternion.identity);

            PoolTeto.Enqueue(go);

            proximaPosicaoTeto.x += go.GetComponent<SpriteRenderer>().bounds.size.x;

       } 
    }
    public void reutilizarTeto()
    {
        GameObject Teto = PoolTeto.Dequeue();

        PoolTeto.Enqueue(Teto);

        Teto.transform.position = proximaPosicaoTeto;

        proximaPosicaoTeto.x += Teto.GetComponent<SpriteRenderer>().bounds.size.x; 
    }
    
    
   
}
