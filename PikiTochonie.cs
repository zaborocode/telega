using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class PikiTochonie : MonoBehaviour
{
    public string sceneName;

    // Update is called once per frame
    void OnTriggerEnter()
    {
        EditorSceneManager.LoadScene(sceneName);
    }
}
