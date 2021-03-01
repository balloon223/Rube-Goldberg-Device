using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform followTransform;
    public Transform followTransform2;
    public Transform followTransform3;
    public Transform followTransform4;
    public Transform followTransform5;
    public Transform followTransform6;    
    public Transform followTransform7;    
    public Transform followTransform8; 
    public Transform followTransform9; 
    public BoxCollider2D worldBounds;
    

    float xmin;
    float xmax;
    float ymin;
    float ymax;

    float camx;
    float camy;

    float camRatio;
    float camSize;

    Camera mainCam;

    Vector3 smoothPos;

    public float smoothRate = 0.01f;


    // Start is called before the first frame update
    void Start()
    {
        xmin = worldBounds.bounds.min.x;
        xmax = worldBounds.bounds.max.x;
        ymin = worldBounds.bounds.min.y;
        ymax = worldBounds.bounds.max.y;

        mainCam = gameObject.GetComponent<Camera>();

        camSize = mainCam.orthographicSize;
        camRatio = (xmax + camSize) / 8.0f;
    }

    // Update is called once per frame
    void Update()
    {
    if(followTransform.position.y >= 0){
        camy = Mathf.Clamp(followTransform.position.y, ymin + camSize, ymax - camSize);
        camx = Mathf.Clamp(followTransform.position.x, xmin + camRatio, xmax - camRatio);
    }

    else if(followTransform2.position.y >= -20){
        camy = Mathf.Clamp(followTransform2.position.y, ymin + camSize, ymax - camSize);
        camx = Mathf.Clamp(followTransform2.position.x, xmin + camRatio, xmax - camRatio);
    }

    else if(followTransform3.position.y >= -30){
        camy = Mathf.Clamp(followTransform3.position.y, ymin + camSize, ymax - camSize);
        camx = Mathf.Clamp(followTransform3.position.x, xmin + camRatio, xmax - camRatio);
    }

    else if(followTransform5.position.y >= -143){
        camy = Mathf.Clamp(followTransform5.position.y, ymin + camSize, ymax - camSize);
        camx = Mathf.Clamp(followTransform5.position.x, xmin + camRatio, xmax - camRatio);
    }
    else if(followTransform6.position.y >= -143){
        camy = Mathf.Clamp(followTransform6.position.y, ymin + camSize, ymax - camSize);
        camx = Mathf.Clamp(followTransform6.position.x, xmin + camRatio, xmax - camRatio);
    }
    else if(followTransform7.position.y >= -143){
        camy = Mathf.Clamp(followTransform7.position.y, ymin + camSize, ymax - camSize);
        camx = Mathf.Clamp(followTransform7.position.x, xmin + camRatio, xmax - camRatio);
    }
    else if(followTransform8.position.y >= -170){
        camy = Mathf.Clamp(followTransform8.position.y, ymin + camSize, ymax - camSize);
        camx = Mathf.Clamp(followTransform8.position.x, xmin + camRatio, xmax - camRatio);
    }
    else if(followTransform9.position.y >= -250){
        camy = Mathf.Clamp(followTransform9.position.y, ymin + camSize, ymax - camSize);
        camx = Mathf.Clamp(followTransform9.position.x, xmin + camRatio, xmax - camRatio);
    }
            smoothPos = Vector3.Lerp(this.transform.position, new Vector3(camx, camy, gameObject.transform.position.z), 0.05f);
    
        gameObject.transform.position = smoothPos;
    }
}
