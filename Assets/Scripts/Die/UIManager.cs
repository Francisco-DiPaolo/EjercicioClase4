using UnityEngine;
using System;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static Action eventUI;

    public Text bonustext;

    void AssingText()
    {
        BonusVerification[] bonusVerification = FindObjectsOfType<BonusVerification>();

        for (int i = 0; i < bonusVerification.Length; i++)
        {
            bonustext.text += (i + 1).ToString() + " " + bonusVerification[i].bonusName;

            if (bonusVerification[i].isActive) bonustext.text = "Mod: " + bonusVerification[i].bonusName;

            else bonustext.text = "Mod: Standart";
        }
    }

    private void OnEnable()
    {
        eventUI += AssingText;
    }

    private void OnDisable()
    {
        eventUI -= AssingText;
    }
}
