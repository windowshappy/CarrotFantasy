using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClipFactory : IBaseResourceFactory<AudioClip>
{
    protected Dictionary<string,AudioClip> factoryDict = new Dictionary<string, AudioClip>();
    protected string loadPath;

    public AudioClipFactory()
    {
        loadPath = "AudioClips/";
    }
    
    public AudioClip GetSingleResources(string resourcesPath)
    {
        AudioClip itemGo = null;
        string itemLoadPath = loadPath + resourcesPath;
        if (factoryDict.ContainsKey(resourcesPath))
        {
            itemGo = factoryDict[resourcesPath];
        }
        else
        {
            itemGo = Resources.Load<AudioClip>(itemLoadPath);
            factoryDict.Add(resourcesPath,itemGo);
        }

        if (itemGo==null)
        {
            Debug.Log(resourcesPath+"的资源获取失败，失败路径为："+itemLoadPath);
        }
        return itemGo;
    }
}
