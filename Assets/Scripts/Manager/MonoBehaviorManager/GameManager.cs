using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

/// <summary>
/// 游戏总管理，负责管理所有的管理者
/// </summary>
public class GameManager : MonoBehaviour
{
    public PlayerManager playerManager;
    public FactoryManager factoryManager;
    public AudioSourceManager audioSourceManager;
    public UIManager uiManager;

    private static GameManager _instance;

    public static GameManager Instance => _instance;
    
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        _instance = this;
        
        playerManager = new PlayerManager();
        factoryManager = new FactoryManager();
        audioSourceManager = new AudioSourceManager();
        uiManager=new UIManager();
    }

    public GameObject CreateItem(GameObject itemGo)
    {
        GameObject go = Instantiate(itemGo);
        return go;
    }
}
