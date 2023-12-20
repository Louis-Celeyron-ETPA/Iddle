using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaunchScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.activeSceneChanged += ManagerManager.OnSceneLoaded;
        SceneManager.LoadScene(1);

    }
}
