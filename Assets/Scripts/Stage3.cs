using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3 : MonoBehaviour
{
    private bool clear2nd = false;
    public GameObject mainCamera;
    public GameObject gameStart;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !clear2nd)
        {
            clear2nd = true;
            mainCamera.transform.rotation = Quaternion.Euler(-90.0f, 100.0f, 0.0f);
            gameStart.GetComponent<GameStart>().setStartPos(new Vector3(40f, 0.0f, 45.5f));
            gameStart.GetComponent<GameStart>().setCameraRot(-90.0f, 100.0f, 0.0f);
        }
    }
}
