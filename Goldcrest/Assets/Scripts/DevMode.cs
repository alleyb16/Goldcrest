using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevMode : MonoBehaviour
{

    public Music music;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enableDevMode() // Embrace the power of a dev
    {
        // unlock all cards
        GameManager.Instance.hasSwordT1 = true;
        GameManager.Instance.numSwordT1++;
        GameManager.Instance.hasSwordT2 = true;
        GameManager.Instance.numSwordT2++;
        GameManager.Instance.hasSwordT3 = true;
        GameManager.Instance.numSwordT3++;
        GameManager.Instance.hasAxeT1 = true;
        GameManager.Instance.numAxeT1++;
        GameManager.Instance.hasAxeT2 = true;
        GameManager.Instance.numAxeT2++;
        GameManager.Instance.hasAxeT3 = true;
        GameManager.Instance.numAxeT3++;
        GameManager.Instance.hasSpearT1 = true;
        GameManager.Instance.numSpearT1++;
        GameManager.Instance.hasSpearT2 = true;
        GameManager.Instance.numSpearT2++;
        GameManager.Instance.hasSpearT3 = true;
        GameManager.Instance.numSpearT3++;
        GameManager.Instance.hasClothT1 = true;
        GameManager.Instance.numClothT1++;
        GameManager.Instance.hasClothT2 = true;
        GameManager.Instance.numClothT2++;
        GameManager.Instance.hasClothT3 = true;
        GameManager.Instance.numClothT3++;
        GameManager.Instance.hasLeatherT1 = true;
        GameManager.Instance.numLeatherT1++;
        GameManager.Instance.hasLeatherT2 = true;
        GameManager.Instance.numLeatherT2++;
        GameManager.Instance.hasLeatherT3 = true;
        GameManager.Instance.numLeatherT3++;
        GameManager.Instance.hasPlateT1 = true;
        GameManager.Instance.numPlateT1++;
        GameManager.Instance.hasPlateT2 = true;
        GameManager.Instance.numPlateT2++;
        GameManager.Instance.hasPlateT3 = true;
        GameManager.Instance.numPlateT3++;
        GameManager.Instance.hasHealingT1 = true;
        GameManager.Instance.numHealingT1++;
        GameManager.Instance.hasHealingT2 = true;
        GameManager.Instance.numHealingT2++;
        GameManager.Instance.hasHealingT3 = true;
        GameManager.Instance.numHealingT3++;

        // Make it rain gold!
        GameManager.Instance.totalCoins += 999999;

        // Play some sick tunes!
        music.startJammin();

        // Unlock all levels
        GameManager.Instance.lvl2Unlocked = true;
        GameManager.Instance.lvl3Unlocked = true;
    }
}
