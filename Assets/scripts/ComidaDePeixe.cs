using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidaDePeixe : MonoBehaviour
{
    [SerializeField]
    HabilidadesGeraisPlayer habilidadesGeraisPlayer;

    //[SerializeField]
    //Player player_ref;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            var player = collision.gameObject.GetComponent<Player>();

            if(player != null)
            {
                habilidadesGeraisPlayer.Comer();//aqui não falta colocar primeiro a classe?
                Destroy(this);
            }
        }
    }
}
