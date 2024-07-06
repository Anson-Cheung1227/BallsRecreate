using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public event EventHandler DeathState; 
    public int Score { get; private set; }= 0;

    private void Awake()
    {
        Instance = this;
    }

    public void AddScore()
    {
        ++Score;
    }

    public void InvokeDeathState()
    {
        DeathState?.Invoke(this, EventArgs.Empty);
    }
}
