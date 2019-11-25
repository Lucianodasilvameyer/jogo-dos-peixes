using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraComLimites : MonoBehaviour
{
    [SerializeField]
    private Transform Player;

    public float boundX = 2.0f;
    public float boundY = 1.5f;

    public float speed = 6.0f;

    private Vector3 PosicaoDesejada;


    // Start is called before the first frame update




    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;

        float dx = Player.position.x - transform.position.x;
        
        if(dx > boundX || dx < -boundX)
        {
            if(transform.position.x < Player.position.x)
            {
                delta.x = dx - boundX;
            }
            else
            {
                delta.x = dx + boundX;
            }
        }
        float dy = Player.position.y - transform.position.y;
        
        if(dy> boundY || dy < -boundY)
        {
            if(transform.position.y < Player.position.y)
            {
                delta.y = dy - boundY;
            }
            else
            {
                delta.y = dy + boundY;
            }
        }
        PosicaoDesejada = transform.position + delta;
        transform.position = Vector3.Lerp(transform.position, PosicaoDesejada , speed); 


    }
}
