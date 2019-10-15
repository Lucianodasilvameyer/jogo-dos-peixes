using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class spawnarInimigos : MonoBehaviour
{
    [SerializeField]
    Player player_ref;

    public GameObject[] TubaraoPrefab;

    public GameObject BackGroundPrefab;
    public GameObject groundPrefab;

    [SerializeField]
    Vector2 nextPositionBG;
    [SerializeField]
    Vector2 nextPositionGR;

    [SerializeField]
    int maxPoolNumber = 2;

    Queue<GameObject> PoolFundo = new Queue<GameObject>();
    Queue<GameObject> Poolchao = new Queue<GameObject>();



    List<GameObject> tubaraoList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < maxPoolNumber; i++)  //
        {
            GameObject go = Instantiate(BackGroundPrefab, nextPositionBG, Quaternion.identity);//nextPositionGR representa a proxima posição q o objeto vai ser spawnado
            PoolFundo.Enqueue(go);


            nextPositionBG.x += go.GetComponent<SpriteRenderer>().bounds.size.x;  //aqui a função bounds.size é o tamanho do objeto e para utiliza-la deve-se usar o go.GetComponent<SpriteRenderer>() antes  e o primeiro x é porque só quer trabalhar com o x
                                                                                  //este  nextPositionBG influencia dentro do instantiate de cima;                                                                      
                                                                                  //o nextPositionBG.x começa em zero e o += serve para ir adicionando o tamanho do sprite?


            go = Instantiate(groundPrefab, nextPositionGR, Quaternion.identity);
            Poolchao.Enqueue(go);

            nextPositionGR.x += go.GetComponent<SpriteRenderer>().bounds.size.x;



        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnarInimigos(int quantidadeIinimigos, float distanceMin, float distanceMax, float heightMax, Vector2 initialPos)
    {

        for (int i = 0; i < quantidadeIinimigos; i++)
        {
            int index = Random.Range(0, TubaraoPrefab.Length);
            Vector2 position = initialPos;  
            position.x += i * Random.Range(distanceMin, distanceMax); 
            position.y += Random.Range(0, heightMax);
            
            GameObject go = Instantiate(TubaraoPrefab[index], position, Quaternion.identity);


        }


    }
    public void ReciclarGR()//aqui os objetos são tirados e colocados na fila
    {
        GameObject chao = Poolchao.Dequeue();

        //o primeiro a sair da fila é o primeiro q entrou na fila
        Poolchao.Enqueue(chao);


        chao.transform.position = nextPositionGR;




        nextPositionGR.x += chao.GetComponent<SpriteRenderer>().bounds.size.x;//sempre q mecher tem q atualizar

    }

    public void ReciclarBG()
    {
        GameObject backGround = PoolFundo.Dequeue();
        PoolFundo.Enqueue(backGround);

        backGround.transform.position = nextPositionBG;
        nextPositionBG.x += backGround.GetComponent<SpriteRenderer>().bounds.size.x;
    }
}
