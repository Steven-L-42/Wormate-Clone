using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeCameraSize : NetworkBehaviour
{
   
    Camera myCamera;
    private void Awake()
    {
        myCamera = Camera.main;

    }
    // Update is called once per frame
    void Update()
    {
        switch (transform.localScale.x)
        {
            case > 20:
                myCamera.orthographicSize = (float)10.0;
                break;
            case > 18:
                myCamera.orthographicSize = (float)9.5;
                break;
            case > 16:
                myCamera.orthographicSize = (float)9.0;
                break;
            case > 14:
                myCamera.orthographicSize = (float)8.5;
                break;
            case > 12:
                myCamera.orthographicSize = (float)8.0;
                break;
            case > 10:
                myCamera.orthographicSize = (float)7.5;
                break;
            case > 8:
                myCamera.orthographicSize = (float)10;
                break;
            case > 6:
                myCamera.orthographicSize = (float)9;
                break;
            case > 4:
                myCamera.orthographicSize = (float)8;
                break;
            case > 2:
                myCamera.orthographicSize = (float)7;
                break;
        }
    }
}
