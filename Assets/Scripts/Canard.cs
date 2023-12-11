using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Duck", menuName ="Fran�ois", order = 0)]
public class Canard : ScriptableObject
{
    public string duckName;
    public int hpMax;
    public Sprite duckSprite;
}
