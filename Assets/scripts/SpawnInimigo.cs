using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInimigo : MonoBehaviour
{
    [SerializeField]
    float groundLevel = -2.65f;

    [SerializeField]
    float distanceEnemyFromPlayer;

    private float timerRespawnInimigos;

    [SerializeField]
    private float timerRespawnInimigosMax;
    [SerializeField]
    private Transform player; 


    public GameObject[] InimigoPrefab;
    // Start is called before the first frame update
    void Start()
    {
       

        

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timerRespawnInimigos + timerRespawnInimigosMax)
        {
            timerRespawnInimigos = Time.time;


            Vector2 initialPos = player.transform.position;
            initialPos.x += distanceEnemyFromPlayer;
            initialPos.y = groundLevel;// aqui o y é sempre o mesmo



            SpawnarInimigos(Random.Range(1, 2), 1, 6, Random.Range(0, 5), initialPos);// o 1,6 são respectivamente a distanceMin e distanceMax entre os inimigos?
        }
    }
    public void SpawnarInimigos(int quantidadeIinimigos, float distanceMin, float distanceMax, float heightMax, Vector2 initialPos)
    {

        for (int i = 0; i < quantidadeIinimigos; i++)
        {
            int index = Random.Range(0, InimigoPrefab.Length);//aqui o tamanho do array tem q ser igual a quantidade de inimigos?
            Vector3 position = initialPos;
            position.x += i * Random.Range(distanceMin, distanceMax);
            position.y += Random.Range(0, heightMax);
            position.z = -1f;

            GameObject go = Instantiate(InimigoPrefab[index], position, Quaternion.identity);
        }
    }
}
