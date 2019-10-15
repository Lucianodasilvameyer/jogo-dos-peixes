using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Game : MonoBehaviour
{
    //public bool recarregar = false;

    //public float TempoDashInicial;

    //public float TempoDashMax;

    [SerializeField]
    Player player_ref;

   // [SerializeField]
    //Cascudo cascudo_ref;

    public Text displayContagem;

    Text textGameOver;

    bool gameOver = false;
        

    public int Contagem;          
    

    public AudioSource audioSource;
    public AudioClip SomDeColisao;

    public GameObject[] inimigosPrefab;
    

    void Start()
    {
        if (Contagem > 0)
        {
            InvokeRepeating("diminui", 1, 1);
        }
        else
        {

            textGameOver.gameObject.SetActive(true);
        }
    }
    void diminui()
    {
        Contagem -= 1;
        displayContagem.text = Contagem.ToString();
    }


    void Update()
    {
        //if (Time.time >= player_ref.TempoDashInicial + player_ref.TempoDashMax && player_ref.recarregar == true)
        //{
        //  player_ref.recarregar = false;
        //}

        // if (Time.time >= cascudo_ref.reativarArmaduraInicial + cascudo_ref.reativarArmaduraMax && cascudo_ref.armadura == false)
        
        //{

          //  cascudo_ref.ataqueDefendido = true;
        //}
    }
    public void spawnarInimigos(int quantidadeDeInimigos, float distanciaMin, float distanciaMax, float heighMax, Vector2 initialPos)
    {
        Vector2 position = player_ref.transform.position;

    }
    public void somPlay(AudioClip som)
    {
        audioSource.clip = som;
        audioSource.Play();
    }
    
}
