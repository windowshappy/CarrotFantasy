using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 负责控制音乐的播放和停止以及游戏中各种音效的播放
/// </summary>
public class AudioSourceManager
{
    private AudioSource[] audioSources;
    private bool playEffectMusic = true;
    private bool playBGMusic = true;

    public AudioSourceManager()
    {
        audioSources = GameManager.Instance.GetComponents<AudioSource>();
    }

    public void PlayBGMusic(AudioClip audioClip)
    {
        if (!audioSources[0].isPlaying||audioSources[0].clip!=audioClip)
        {
            audioSources[0].clip = audioClip;
            audioSources[0].Play();
        }
    }

    public void PlayEffectMusic(AudioClip audioClip)
    {
        if (playEffectMusic)
        {
            audioSources[1].PlayOneShot(audioClip);
        }
    }

    public void CloseBGMusic()
    {
        audioSources[0].Stop();
    }

    public void OpenBGMusic()
    {
        audioSources[0].Play();
    }
}
