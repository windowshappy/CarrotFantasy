using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DoTweenTest : MonoBehaviour
{
    private Image maskImage;
    private Tween maskTween;

    private void Start()
    {
        maskImage = GetComponent<Image>();
        
        /*//1.doTween的静态方法
        DOTween.To(() => maskImage.color, toColor => maskImage.color = toColor, new Color(0f, 0f, 0f, 0f), 2f);
        //详细分解
        DOTween.To(() =>
            maskImage.color//我们想改变的对象值
            , toColor//每次doTween经过计算得到的结果
            => maskImage.color = toColor, //将计算结果赋给我们想改变的对象值
            new Color(0f, 0f, 0f, 0f), 2f);//目标值，完成动画的时间*/
        /*//1.doTween用于transform的方法
        Tween tween = transform.DOLocalMoveX(300, 0.5f);
        tween.PlayForward();
        tween.PlayBackwards();
        //结论：直接倒着播放还是先正播再倒播，不存在直接倒着播*/
        //动画的循环使用
        maskTween = transform.DOLocalMoveX(300, 0.5f);
        maskTween.SetAutoKill(false);
        maskTween.Pause();
        
        //动画的事件回调
        Tween tween = transform.DOLocalMoveX(300, 0.5f);
        tween.OnComplete(CompleteMethod);
        
        //动画的缓动函数以及循环状跟次数
        tween.SetEase(Ease.InOutBounce);
        tween.SetLoops(-1, LoopType.Yoyo);
    }

    private void Update()
    {
        //tween play方法只能播一次不能倒播
        if (Input.GetMouseButtonDown(0)) maskTween.PlayForward();
        else if (Input.GetMouseButtonDown(1)) maskTween.PlayBackwards();
    }

    private void CompleteMethod()
    {
        DOTween.To(() => maskImage.color, toColor => maskImage.color = toColor, new Color(0f, 0f, 0f, 0f), 2f);
    }
}
