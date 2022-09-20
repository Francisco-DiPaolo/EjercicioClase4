using System;
using UnityEngine;

public class BonusManager : MonoBehaviour
{
    public static Action<int> bonusEvent;

    public static Action findEvent;

    BonusVerification[] bonusVerification;

    private void Start()
    {
        bonusVerification = FindObjectsOfType<BonusVerification>();
    }

    void FindBonus()
    {
        int value = 0;

        foreach (var item in bonusVerification)
        {
            if (item.isActive) value += item.value;
        }
        bonusEvent?.Invoke(value);
    }

    private void Update()
    {
        if (Input.anyKeyDown) ActivateExtras();
    }

    void ActivateExtras()
    {
        for (int i = 0; i < bonusVerification.Length; i++)
        {
            if (Input.GetKeyDown((i + 1).ToString())) bonusVerification[i].Activate();
        }
    }

    private void OnEnable()
    {
        findEvent += FindBonus;
    }
    private void OnDisable()
    {
        findEvent -= FindBonus;
    }
}
