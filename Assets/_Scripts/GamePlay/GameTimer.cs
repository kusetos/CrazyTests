using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;

public class GameTimer : ITickable
{
    private float _elapsedTime;
    private bool _isRunning = false;

    public void StartTimer(float time)
    {
        _isRunning = true;
        _elapsedTime = time;
    }
    public void StopTimer()
    {
        _isRunning=false;
    }
    public float GetElapsedTime => _elapsedTime;
    public string GetLeftSeconds()
    {
        TimeSpan timeSpan = TimeSpan.FromSeconds(GetElapsedTime);

        return string.Format("{0:D2}:{1:D2}", (int)timeSpan.TotalMinutes, timeSpan.Seconds);
    }
    public void Tick()
    {
        if( _isRunning )
        {
            _elapsedTime -= Time.deltaTime;
        }
        if(GetElapsedTime < 0)
        {
            StopTimer();
        }
        
    }
}
                                                                    