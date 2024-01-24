using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DuckInGame: MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public TextMeshProUGUI nameUI;
    public Duck[] ducksToRead;
    private Duck currentDuck;
    private DuckManager _duckManager;

    public Slider affectionSlider;
    private int _affection;
    private int _AffectionMax => currentDuck.affectionNeeded;

    private void Awake()
    {
        _duckManager = ManagerManager.GetManager<DuckManager>();
        _duckManager.duckInGame = this;
    }

    public void RiseAffection(int amount)
    {
        SetAffection(_affection + amount);
    }
    public void SetAffection(int newAffection)
    {
        _affection = newAffection;
        AffectionFeedback();
        if(_affection>=_AffectionMax)
        {
            Tame();
        }
    }

    public void ReadDuck(Duck duck)
    {
        currentDuck = duck;
        spriteRenderer.sprite = currentDuck.duckSprite;
        nameUI.text = currentDuck.name;
        SetAffection(0);
    }

    public void Tame()
    {
        TameFeedback();
        _duckManager.GenerateRandomDuck();
    }

    private void TameFeedback()
    {

    }

    private void AffectionFeedback()
    {
        affectionSlider.value = (float)_affection / (float)_AffectionMax;
    }

    private void OnMouseDown()
    {
        RiseAffection(1);
    }
}
