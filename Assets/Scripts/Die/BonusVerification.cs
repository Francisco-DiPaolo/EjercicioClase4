using UnityEngine;

public class BonusVerification : MonoBehaviour
{
    public int value;
    public string bonusName;
    public bool isActive;

    public void Activate()
    {
        isActive = !isActive;
        BonusManager.findEvent?.Invoke();
        UIManager.eventUI?.Invoke();
    }
}
