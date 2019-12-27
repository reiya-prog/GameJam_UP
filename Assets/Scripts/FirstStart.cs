using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown) {
			foreach(var c in Input.inputString) {
				if(c == "\n"[0] || c == "\r"[0]) {
                    SceneManager.LoadScene("GamePlay");
                    SceneManager.UnloadSceneAsync("GameStart");
                }
			}
		}
    }
}
