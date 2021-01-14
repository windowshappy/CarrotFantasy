using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 负责管理UI的管理者
/// </summary>
public class UIManager
{
    public UIFacade mUIFacade;
    public Dictionary<string,GameObject> currentScenePanelDict = new Dictionary<string, GameObject>();
    private GameManager mGameManager;
    
    public UIManager()
    {
        mGameManager = GameManager.Instance;
        currentScenePanelDict = new Dictionary<string, GameObject>();
        mUIFacade = new UIFacade();
    }
}
