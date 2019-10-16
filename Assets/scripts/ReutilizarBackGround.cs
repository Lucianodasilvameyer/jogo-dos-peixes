using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReutilizarBackGround : MonoBehaviour
{
    ReutilizarChao reutilizarChao;


    public GameObject fundoPrefab;

    [SerializeField]
    Vector2 proximaPosicaoFundo;

    Queue<GameObject> PoolFundo = new Queue<GameObject>();



    private void Awake()
    {
        reutilizarChao.GetComponent<ReutilizarChao>();
    }
    // Start is called before the first frame update
    void Start()
    {
       for(int i=0; i < reutilizarChao.numeroMaxPool; i++)
       {
            GameObject se = Instantiate(fundoPrefab, proximaPosicaoFundo, Quaternion.identity);

            PoolFundo.Enqueue(se);

            proximaPosicaoFundo.x += se.GetComponent<SpriteRenderer>().bounds.size.x;
            
       } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void reutilizarBackGround()
    {
        

        GameObject fundo = PoolFundo.Dequeue();
        PoolFundo.Enqueue(fundo);

        fundo.transform.position = proximaPosicaoFundo;

        proximaPosicaoFundo.x += fundo.GetComponent<SpriteRenderer>().bounds.size.x;

    }
}
