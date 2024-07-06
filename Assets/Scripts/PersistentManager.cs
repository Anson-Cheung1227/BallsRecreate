using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PersistentManager : MonoBehaviour
{
    public static PersistentManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        if (!Application.isEditor)
        {
            SceneManager.LoadScene("Core", LoadSceneMode.Additive);
            SceneManager.LoadScene("UI", LoadSceneMode.Additive);
        }
    }

    public void Restart()
    {
        SceneManager.UnloadSceneAsync("UI");
        SceneManager.UnloadSceneAsync("Core");
        SceneManager.LoadScene("Core", LoadSceneMode.Additive);
        SceneManager.LoadScene("UI", LoadSceneMode.Additive);
    }
}
