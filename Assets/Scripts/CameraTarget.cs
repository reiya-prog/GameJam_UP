using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    public GameObject unitychan;
    Vector3 Delta30 = new Vector3(-2.5f, -2.0f, -3.5f);
    Vector3 Delta50 = new Vector3(-2.0f, -2.0f, 3.0f);
    Vector3 Delta90 = new Vector3(0.0f, -3.0f, 0.0f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.transform.rotation.eulerAngles.x - 360 > -31.0f)
            this.gameObject.transform.position = unitychan.GetComponent<Transform>().position + Delta30;
        else if(this.gameObject.transform.rotation.eulerAngles.x - 360 > -51.0f)
            this.gameObject.transform.position = unitychan.GetComponent<Transform>().position + Delta50;
        else if(this.gameObject.transform.rotation.eulerAngles.x - 360 > -91.0f)
            this.gameObject.transform.position = unitychan.GetComponent<Transform>().position + Delta90;
    }
}
