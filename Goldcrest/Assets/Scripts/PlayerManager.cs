using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Used to help enemies locate player
    #region Singleton
    public static PlayerManager instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion

    public GameObject player;
}
