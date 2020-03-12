using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerIndex : MonoBehaviour
{
    public static ManagerIndex MI;

    [SerializeField] private GameManager gameManager;
    [SerializeField] private ColorManager colorManager;
    [SerializeField] private TimeManager timeManager;
    [SerializeField] private MoneyManager moneyManager;

    public GameManager GameManager => gameManager;

    public ColorManager ColorManager => colorManager;

    public TimeManager TimeManager => timeManager;

    public MoneyManager MoneyManager => moneyManager;

    private void Awake()
    {
        if (!MI) MI = this;
        else Destroy(gameObject);
    }
}
