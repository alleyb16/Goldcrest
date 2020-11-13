using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearSwap : MonoBehaviour
{
    public GameObject swordT1;
    public GameObject swordT2;
    public GameObject swordT3;
    public GameObject axeT1;
    public GameObject axeT2;
    public GameObject axeT3;
    public GameObject spearT1;
    public GameObject spearT2;
    public GameObject spearT3;

    public GameObject clothT1;
    public GameObject clothT2;
    public GameObject clothT3;
    public GameObject leatherT1;
    public GameObject leatherT2;
    public GameObject leatherT3;
    public GameObject plateT1;
    public GameObject plateT2;
    public GameObject plateT3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void equipGear() // Changes visual representation of equipped items in game
    {
        if (GameManager.Instance.SwordT1) // WEAPONS
        {
            swordT1.SetActive(true);
            swordT2.SetActive(false);
            swordT3.SetActive(false);
            axeT1.SetActive(false);
            axeT2.SetActive(false);
            axeT3.SetActive(false);
            spearT1.SetActive(false);
            spearT2.SetActive(false);
            spearT3.SetActive(false);
        }
        if (GameManager.Instance.SwordT2)
        {
            swordT1.SetActive(false);
            swordT2.SetActive(true);
            swordT3.SetActive(false);
            axeT1.SetActive(false);
            axeT2.SetActive(false);
            axeT3.SetActive(false);
            spearT1.SetActive(false);
            spearT2.SetActive(false);
            spearT3.SetActive(false);
        }
        if (GameManager.Instance.SwordT3)
        {
            swordT1.SetActive(false);
            swordT2.SetActive(false);
            swordT3.SetActive(true);
            axeT1.SetActive(false);
            axeT2.SetActive(false);
            axeT3.SetActive(false);
            spearT1.SetActive(false);
            spearT2.SetActive(false);
            spearT3.SetActive(false);
        }
        if (GameManager.Instance.AxeT1)
        {
            swordT1.SetActive(false);
            swordT2.SetActive(false);
            swordT3.SetActive(false);
            axeT1.SetActive(true);
            axeT2.SetActive(false);
            axeT3.SetActive(false);
            spearT1.SetActive(false);
            spearT2.SetActive(false);
            spearT3.SetActive(false);
        }
        if (GameManager.Instance.AxeT2)
        {
            swordT1.SetActive(false);
            swordT2.SetActive(false);
            swordT3.SetActive(false);
            axeT1.SetActive(false);
            axeT2.SetActive(true);
            axeT3.SetActive(false);
            spearT1.SetActive(false);
            spearT2.SetActive(false);
            spearT3.SetActive(false);
        }
        if (GameManager.Instance.AxeT3)
        {
            swordT1.SetActive(false);
            swordT2.SetActive(false);
            swordT3.SetActive(false);
            axeT1.SetActive(false);
            axeT2.SetActive(false);
            axeT3.SetActive(true);
            spearT1.SetActive(false);
            spearT2.SetActive(false);
            spearT3.SetActive(false);
        }
        if (GameManager.Instance.SpearT1)
        {
            swordT1.SetActive(false);
            swordT2.SetActive(false);
            swordT3.SetActive(false);
            axeT1.SetActive(false);
            axeT2.SetActive(false);
            axeT3.SetActive(false);
            spearT1.SetActive(true);
            spearT2.SetActive(false);
            spearT3.SetActive(false);
        }
        if (GameManager.Instance.SpearT2)
        {
            swordT1.SetActive(false);
            swordT2.SetActive(false);
            swordT3.SetActive(false);
            axeT1.SetActive(false);
            axeT2.SetActive(false);
            axeT3.SetActive(false);
            spearT1.SetActive(false);
            spearT2.SetActive(true);
            spearT3.SetActive(false);
        }
        if (GameManager.Instance.SpearT3)
        {
            swordT1.SetActive(false);
            swordT2.SetActive(false);
            swordT3.SetActive(false);
            axeT1.SetActive(false);
            axeT2.SetActive(false);
            axeT3.SetActive(false);
            spearT1.SetActive(false);
            spearT2.SetActive(false);
            spearT3.SetActive(true);
        }

        if (GameManager.Instance.ClothT1) // ARMOR
        {
            clothT1.SetActive(true);
            clothT2.SetActive(false);
            clothT3.SetActive(false);
            leatherT1.SetActive(false);
            leatherT2.SetActive(false);
            leatherT3.SetActive(false);
            plateT1.SetActive(false);
            plateT2.SetActive(false);
            plateT3.SetActive(false);
        }
        if (GameManager.Instance.ClothT2)
        {
            clothT1.SetActive(false);
            clothT2.SetActive(true);
            clothT3.SetActive(false);
            leatherT1.SetActive(false);
            leatherT2.SetActive(false);
            leatherT3.SetActive(false);
            plateT1.SetActive(false);
            plateT2.SetActive(false);
            plateT3.SetActive(false);
        }
        if (GameManager.Instance.ClothT3)
        {
            clothT1.SetActive(false);
            clothT2.SetActive(false);
            clothT3.SetActive(true);
            leatherT1.SetActive(false);
            leatherT2.SetActive(false);
            leatherT3.SetActive(false);
            plateT1.SetActive(false);
            plateT2.SetActive(false);
            plateT3.SetActive(false);
        }
        if (GameManager.Instance.LeatherT1)
        {
            clothT1.SetActive(false);
            clothT2.SetActive(false);
            clothT3.SetActive(false);
            leatherT1.SetActive(true);
            leatherT2.SetActive(false);
            leatherT3.SetActive(false);
            plateT1.SetActive(false);
            plateT2.SetActive(false);
            plateT3.SetActive(false);
        }
        if (GameManager.Instance.LeatherT2)
        {
            clothT1.SetActive(false);
            clothT2.SetActive(false);
            clothT3.SetActive(false);
            leatherT1.SetActive(false);
            leatherT2.SetActive(true);
            leatherT3.SetActive(false);
            plateT1.SetActive(false);
            plateT2.SetActive(false);
            plateT3.SetActive(false);
        }
        if (GameManager.Instance.LeatherT3)
        {
            clothT1.SetActive(false);
            clothT2.SetActive(false);
            clothT3.SetActive(false);
            leatherT1.SetActive(false);
            leatherT2.SetActive(false);
            leatherT3.SetActive(true);
            plateT1.SetActive(false);
            plateT2.SetActive(false);
            plateT3.SetActive(false);
        }
        if (GameManager.Instance.PlateT1)
        {
            clothT1.SetActive(false);
            clothT2.SetActive(false);
            clothT3.SetActive(false);
            leatherT1.SetActive(false);
            leatherT2.SetActive(false);
            leatherT3.SetActive(false);
            plateT1.SetActive(true);
            plateT2.SetActive(false);
            plateT3.SetActive(false);
        }
        if (GameManager.Instance.PlateT2)
        {
            clothT1.SetActive(false);
            clothT2.SetActive(false);
            clothT3.SetActive(false);
            leatherT1.SetActive(false);
            leatherT2.SetActive(false);
            leatherT3.SetActive(false);
            plateT1.SetActive(false);
            plateT2.SetActive(true);
            plateT3.SetActive(false);
        }
        if (GameManager.Instance.PlateT3)
        {
            clothT1.SetActive(false);
            clothT2.SetActive(false);
            clothT3.SetActive(false);
            leatherT1.SetActive(false);
            leatherT2.SetActive(false);
            leatherT3.SetActive(false);
            plateT1.SetActive(false);
            plateT2.SetActive(false);
            plateT3.SetActive(true);
        }
    }
}
