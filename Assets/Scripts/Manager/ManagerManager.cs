using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class ManagerManager : MonoBehaviour
{
    private static ManagerManager _ManagerManagerInstance;
    private List<Manager> _subManagers;

    private void Awake()
    {
        if(_ManagerManagerInstance == null)
        {
            Register();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        foreach (var manager in _subManagers)
        {
            manager.OnSceneLoaded();
        }
    }

    private void Register()
    {
        _ManagerManagerInstance = this;
        _subManagers = GetComponents<Manager>().ToList();
        DontDestroyOnLoad(gameObject);
    }

    public static void OnSceneLoaded(UnityEngine.SceneManagement.Scene sceneOne, UnityEngine.SceneManagement.Scene sceneTwo)
    {
        foreach (var manager in ManagerManager._ManagerManagerInstance._subManagers)
        {
            manager.OnSceneLoaded();
        }
    }


    public static T GetManager<T>() where T : Manager
    {
        foreach (var manager in _ManagerManagerInstance._subManagers)
        {
            if(manager.GetType() == typeof(T))
            {
                return manager as T;
            }
        }

        return null;
    }
}
