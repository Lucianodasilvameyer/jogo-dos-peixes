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
    Player player_ref;

    public GameObject[] TubaraoPrefab;
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


            Vector2 initialPos = player_ref.transform.position;
            initialPos.x += distanceEnemyFromPlayer;
            initialPos.y = groundLevel;// aqui o y é sempre o mesmo



            SpawnarInimigos(Random.Range(2, 5), 1, 6, Random.Range(0, 5), initialPos);// o 1,6 são respectivamente a distanceMin e distanceMax entre os inimigos?
        }
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
}
