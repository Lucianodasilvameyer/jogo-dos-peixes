﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Game : MonoBehaviour
{
    public static Game instance;//aqui só cria uma vez este objeto
    
    // Start is called before the first frame update

    public GameObject[] inimigosPrefab;

    [SerializeField]
    Player player_ref;
    void Start()
    {
        player_ref = gameObject.GetComponent<Player>();
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
