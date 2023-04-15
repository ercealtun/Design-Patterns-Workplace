using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyData enemyData = null;
    
    private float _currentSpeed = 0f;
    private int _currentHp = 100;

    private void Start()
    {
        var maxSpeed = enemyData.MaxSpeed;
        Debug.Log(maxSpeed);
    }
}
