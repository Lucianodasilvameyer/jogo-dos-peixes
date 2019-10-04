using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip SomDeColisao;

    [SerializeField]
    protected float strength; //o q é protected?

    [SerializeField]
    private Transform target;

    [SerializeField]
    float speed;

    [SerializeField]
    private Vector2 direction;

    

    // Start is called before the first frame update
    void Start()
    {
        DefinirAlvo();
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
    }
    public void Mover()
    {
       
        transform.Translate(speed* direction* Time.deltaTime);
    }
    



    public void DefinirAlvo()
    {
        if(!target || target == null)
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;

            direction = target.position - transform.position;
            direction = direction.normalized;
        }
    }
    public void somPlay(AudioClip som)
    {
        audioSource.clip = som;
        audioSource.Play();
    }
    public virtual void CausarDano(Player alvo)//pq usar este virtual se não á metodos com overload?
    {
        alvo.TomarDano((int)strength);
    }
    
}
