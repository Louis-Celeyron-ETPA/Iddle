using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckManager : Manager
{
    [SerializeField]
    private WeightedList<Duck> _duckList; // Ajouter des appeau pour augmenter le % de rate des cannard avec peut etre une classe intermediaire qui permet de voir les Ducks qu'on débloque
    public DuckInGame duckInGame;
    
    public override void OnSceneLoaded()
    {
        GenerateRandomDuck();
    }

    public void GenerateRandomDuck()
    {
        var selectedDuck = _duckList.GetRandomElement();
        Debug.Log(selectedDuck);
        duckInGame.ReadDuck(selectedDuck);
    }

}
