using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckManager : Manager
{
    [SerializeField]
    private WeightedList<Duck> _duckList; // Ajouter des appeau pour augmenter le % de rate des cannard avec peut etre une classe intermediaire qui permet de voir les Ducks qu'on débloque
    private DuckInGame _duckInGame;


    public override void OnSceneLoaded()
    {
        _duckInGame = FindObjectOfType<DuckInGame>();
        GenerateRandomDuck();
    }

    public void GenerateRandomDuck()
    {
        var selectedDuck = _duckList.GetRandomElement();
        _duckInGame.ReadDuck(selectedDuck);
    }

}
