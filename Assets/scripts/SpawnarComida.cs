using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnarComida : MonoBehaviour
{
    [SerializeField]
    private float distanciaComidaPlayer;

    [SerializeField]
    Transform player;

    [SerializeField]
    float nivelDoChao;

    public GameObject comidaPrefab;

    private float timerSpawnComida;

    [SerializeField]
    private float timerSpawnComidaMax;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timerSpawnComida + timerSpawnComidaMax)
        {
            timerSpawnComida = Time.time;

            Vector2 position = player.transform.position;

            position.x += distanciaComidaPlayer;
            position.y = nivelDoChao;

            spawnarComida(Random.Range(1, 2), 1, 5, Random.Range(0, 5), position);
        } 
    }
    public void spawnarComida(int quantidadeComida, int distanciaMin,int distanciaMax,int alturaMax, Vector2 position)
    {
        for(int i=0; i < quantidadeComida; i++)
        {
            position.x +=i* Random.Range(distanciaMin, distanciaMax);//o position.x e o position.y daqui, são parametros e não argumentos?
            position.y += Random.Range(0, alturaMax);

            GameObject ra = Instantiate(comidaPrefab, position, Quaternion.identity);
        }
    }
}
