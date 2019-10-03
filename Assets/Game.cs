using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Game : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] inimigosPrefab;

    public Player player_ref;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawnarInimigos(int quantidadeDeInimigos, float distanciaMin,float distanciaMax, float heighMax, Vector2 initialPos )
    {
        Vector2 position = player_ref.transform.position;
        
    }
}
