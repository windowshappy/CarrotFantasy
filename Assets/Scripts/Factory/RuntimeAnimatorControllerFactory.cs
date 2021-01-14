using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuntimeAnimatorControllerFactory : IBaseResourceFactory<RuntimeAnimatorController>
{
    protected Dictionary<string,RuntimeAnimatorController> factoryDict = new Dictionary<string, RuntimeAnimatorController>();
    protected string loadPath;

    public RuntimeAnimatorControllerFactory()
    {
        loadPath = "Animator";
    }
    
    public RuntimeAnimatorController GetSingleResources(string resourcesPath)
    {
        RuntimeAnimatorController itemGo = null;
        string itemLoadPath = loadPath + resourcesPath;
        if (factoryDict.ContainsKey(resourcesPath))
        {
            itemGo = factoryDict[resourcesPath];
        }
        else
        {
            itemGo = Resources.Load<RuntimeAnimatorController>(itemLoadPath);
            factoryDict.Add(resourcesPath,itemGo);
        }

        if (itemGo==null)
        {
            Debug.Log(resourcesPath+"的资源获取失败，失败路径为："+itemLoadPath);
        }
        return itemGo;
    }
}
