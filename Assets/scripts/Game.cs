using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Game : MonoBehaviour
{
    public Text displayContagem;

    Text textGameOver;

    bool gameOver = false;
    

    //public TextMeshProUGUI textoGameOver;

    public int Contagem;          
    
    public static Game scriptGame;

    public AudioSource audioSource;
    public AudioClip SomDeColisao;

    public GameObject[] inimigosPrefab;
    Player player_ref;

    void Start()
    {
        if (Contagem >= 0)
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
        if (Time.time >= Player.scripPlayer.TempoDashInicial + Player.scripPlayer.TempoDashMax && Player.scripPlayer.recarregar == true)
        {
            Player.scripPlayer.recarregar = false;
        }

        if (Time.time >= Cascudo.scriptCascudo.reativarArmaduraInicial + Cascudo.scriptCascudo.reativarArmaduraMax && Cascudo.scriptCascudo.armadura == false)
        {

            Cascudo.scriptCascudo.ataqueDefendido = true;
        }


        



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
    //public bool isGameOver()
    //{
       // return gameOver;
    //}

    //public void GameOver()
    //{
      //  textoGameOver.text = "GameOver";
        //gameOver = true;
        //player_ref.GetComponent<SpriteRenderer>().enabled = false;
        

        
   // }
    /* public void contagemRegressiva()
       {
         if (Contagem > 0.0f)
         {
             Contagem -= Time.deltaTime;
             displayContagem.text = Contagem.ToString();

         }
         else
         {
             displayContagem.text = "Morreu de fome!";
         }
       }*/
}
