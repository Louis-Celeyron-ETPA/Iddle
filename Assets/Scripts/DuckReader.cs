using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DuckReader : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public TextMeshProUGUI nameUI, lifeUI;
    public Canard[] ducksToRead;
    private Canard currentDuck;
    public int hp;

    void Start()
    {
        ReadDuck();
    }

    public void ReadDuck()
    {
        currentDuck = ducksToRead[Random.Range(0, ducksToRead.Length)];
        spriteRenderer.sprite = currentDuck.duckSprite;
        nameUI.text = currentDuck.duckName;
        hp = currentDuck.hpMax;
        lifeUI.text = hp.ToString();
    }

    private void OnMouseDown()
    {
        hp -= 1;
        lifeUI.text = hp.ToString();
        if(hp<=0)
        {
            ReadDuck() ;
        }

    }
}
