using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreinoSpawnarComida1 : MonoBehaviour
{
    public GameObject[] comidaPrefab;

    [SerializeField]
    private float distanciaComidaPlayer;

    [SerializeField]
    private float distanciaMaxChao;

    private float TimeSpawnComida;

    [SerializeField]
    private float TimerSpawnComidaMax;

    [SerializeField]
    Transform player;

    

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= TimeSpawnComida + TimerSpawnComidaMax)
        {
            Vector2 position = player.transform.position;
            position.x += distanciaComidaPlayer;
            position.y = distanciaMaxChao;

            TimeSpawnComida = Time.time;

            spawnarComida(Random.Range(1, 2), 1, 6, Random.Range(0, 6), position);
        }
    }
    public void spawnarComida(int quantidadeDeComida,int distanciaMin,int distanciaMax,int alturaMax, Vector2 position)
    {
        for(int i = 0; i < quantidadeDeComida; i++)
        {
            int index = Random.Range(0, comidaPrefab.Length); 
            position.x += Random.Range(distanciaMin, distanciaMax);
            position.y += Random.Range(0, alturaMax);

            GameObject fe = Instantiate(comidaPrefab[index], position, Quaternion.identity);
        }
    }
}
