using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReutilizarTeto : MonoBehaviour
{
    ReutilizarChao reutilizarChao;

    public GameObject Tetoprefab;

    [SerializeField]
    Vector2 ProximaPosicaoTeto;

    Queue<GameObject> PoolTeto = new Queue<GameObject>();


    private void Awake()
    {
        reutilizarChao = GetComponent<ReutilizarChao>();
    }

    // Start is called before the first frame update
    void Start()
    {
       for(int i=0; i < reutilizarChao.numeroMaxPool; i++)
       {
            GameObject go = Instantiate(Tetoprefab, ProximaPosicaoTeto, Quaternion.identity);

            PoolTeto.Enqueue(go);

            ProximaPosicaoTeto.x += go.GetComponent<SpriteRenderer>().bounds.size.x;

       } 
    }
    public void reutilizarTeto()
    {
        GameObject Teto = PoolTeto.Dequeue();//??

        PoolTeto.Enqueue(Teto);//??

        Teto.transform.position = ProximaPosicaoTeto;

        ProximaPosicaoTeto.x += Teto.GetComponent<SpriteRenderer>().bounds.size.x; 
    }
    
    
   
}
