using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewTest : MonoBehaviour
{
    private ScrollRect scrollRect;
    private RectTransform contentRectTrans;

    private void Start()
    {
        scrollRect = GetComponent<ScrollRect>();

        contentRectTrans = scrollRect.content;
        
        Debug.Log("世界坐标："+contentRectTrans.position);
        Debug.Log("局部坐标："+contentRectTrans.localPosition);
        Debug.Log("宽度："+contentRectTrans.rect.xMax);
    }
}
