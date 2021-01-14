using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFactory : IBaseResourceFactory<Sprite>
{
    protected Dictionary<string,Sprite> factoryDict = new Dictionary<string, Sprite>();
    protected string loadPath;

    public SpriteFactory()
    {
        loadPath = "Pictures/";
    }
    
    public Sprite GetSingleResources(string resourcesPath)
    {
        Sprite itemGo = null;
        string itemLoadPath = loadPath + resourcesPath;
        if (factoryDict.ContainsKey(resourcesPath))
        {
            itemGo = factoryDict[resourcesPath];
        }
        else
        {
            itemGo = Resources.Load<Sprite>(itemLoadPath);
            factoryDict.Add(resourcesPath,itemGo);
        }

        if (itemGo==null)
        {
            Debug.Log(resourcesPath+"的资源获取失败，失败路径为："+itemLoadPath);
        }
        return itemGo;
    }
}
