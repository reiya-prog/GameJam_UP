using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public GameObject unitychan;
    public GameObject mainCamera;
    private static Vector3 startPos = new Vector3(0.0f, 0.0f, 0.0f);
    private static float cameraRotX = -30.0f;
    private static float cameraRotY = 0.0f;
    private static float cameraRotZ = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        unitychan.transform.position = startPos;
        mainCamera.transform.rotation = Quaternion.Euler(cameraRotX, cameraRotY, cameraRotZ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setStartPos(Vector3 v){
        startPos = v;
    }

    public void setCameraRot(float x, float y, float z){
        cameraRotX = x;
        cameraRotY = y;
        cameraRotZ = z;
    }
}
