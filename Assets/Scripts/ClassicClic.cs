using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicClic : MonoBehaviour
{
    public int clickPower = 1;
    public ScoreManager scoreManager;


    public void UpgradeClick()
    {
        clickPower += 1;
    }

    public void ClickWithPower()
    {
        scoreManager.RiseScore(clickPower);
    }

}
