using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClickManager : Manager
{

    public ScoreManager scoreManager;
    public int clickPower;
    public float timeBetClick = 1;

    void Start()
    {
        StartCoroutine(AutoClicker());
    }
    
    public void UpgradeAutoClic()
    {
        clickPower += 1;
    }

    private IEnumerator AutoClicker()
    {
        while (true)
        {
            scoreManager.RiseScore(clickPower);
            yield return new WaitForSeconds(timeBetClick);
        }
    }


}
