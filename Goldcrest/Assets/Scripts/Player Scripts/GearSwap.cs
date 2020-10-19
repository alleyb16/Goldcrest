using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearSwap : MonoBehaviour
{
    public GameObject sword;
    public GameObject axe;
    public GameObject spear;

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
        if (GameManager.Instance.SwordT1 || GameManager.Instance.SwordT2 || GameManager.Instance.SwordT3)
        {
            sword.SetActive(true);
            axe.SetActive(false);
            spear.SetActive(false);
        }
        if (GameManager.Instance.AxeT1 || GameManager.Instance.AxeT2 || GameManager.Instance.AxeT3)
        {
            sword.SetActive(false);
            axe.SetActive(true);
            spear.SetActive(false);
        }
        if (GameManager.Instance.SpearT1 || GameManager.Instance.SpearT2 || GameManager.Instance.SpearT3)
        {
            sword.SetActive(false);
            axe.SetActive(false);
            spear.SetActive(true);
        }

        if (GameManager.Instance.ClothT1)
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
