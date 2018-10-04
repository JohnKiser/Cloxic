using UnityEngine;
using UnityEngine.Networking;

public class PlayerMovement : NetworkBehaviour
{
    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        float x = .1f;

        if (Input.GetKey("d"))
        {
            transform.Translate(x, 0, 0);
            
        }

        else if (Input.GetKey("a"))
        {
            transform.Translate(-x, 0, 0);
            
        }

        else if (Input.GetKey("w"))
        {
            transform.Translate(0, 0, x);
            
        }

        else if (Input.GetKey("s"))
        {
            transform.Translate(0, 0, -x);
            
        }
        //var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        //var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        //transform.Translate(x, 0, z);        

    }
}