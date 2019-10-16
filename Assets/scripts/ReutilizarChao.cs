using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReutilizarChao : MonoBehaviour
{
    public GameObject chaoPrefab;

    [SerializeField]
    Vector2 proximaPosicaoChao;

    Queue<GameObject> PoolChao = new Queue<GameObject>();

    
    public int numeroMaxPool = 2;


    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i < numeroMaxPool; i++)
        {
            GameObject ru = Instantiate(chaoPrefab, proximaPosicaoChao, Quaternion.identity);
            PoolChao.Enqueue(ru);

            proximaPosicaoChao.x += ru.GetComponent<SpriteRenderer>().bounds.size.x;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void reutilizarChao()
    {
        GameObject Chao = PoolChao.Dequeue();

        PoolChao.Enqueue(Chao);

        Chao.transform.position = proximaPosicaoChao;

        proximaPosicaoChao.x = Chao.GetComponent<SpriteRenderer>().bounds.size.x;

    }
    

}
