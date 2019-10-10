using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiranhaPowerUp : MonoBehaviour
{

    public GameObject PowerUpPrefab;//??
    
    [SerializeField]
    Player player_ref;

    [SerializeField]
    Piranha piranha_ref;

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
        if (collision.gameObject.CompareTag("Player"))
        {
            var piranha = collision.gameObject.GetComponent<Piranha>();

            if(piranha != null)
            {
                piranha_ref.Cardume();
            }
            Destroy(this);
            
        }
    }
    
    public void spawnarPowerUp(int distanciaPowerUpPlayer)
    {
        Vector2 position = player_ref.transform.position;
        position.x += distanciaPowerUpPlayer;
        position.y += distanciaPowerUpPlayer;

        Instantiate(PowerUpPrefab, position, Quaternion.identity);
    }
}

