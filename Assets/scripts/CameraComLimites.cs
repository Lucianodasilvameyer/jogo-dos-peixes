using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraComLimites : MonoBehaviour
{
    [SerializeField]
    private Transform Alvo;

    public float boundX = 2.0f;
    public float boundY = 1.5f;


    // Start is called before the first frame update
    
        
    

    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;

        float dx = Alvo.position.x - transform.position.x;
        
        if(dx > boundX || dx < -boundX)
        {
            if(transform.position.x < Alvo.position.x)
            {
                delta.x = dx - boundX;
            }
            else
            {
                delta.x = dx + boundX;
            }
        }
        float dy = Alvo.position.y - transform.position.y;
        
        if(dy> boundX || dy < -boundY)
        {
            if(transform.position.y < Alvo.position.y)
            {

            }
        }
    }
}
