using UnityEngine;
using UnityEngine.UI;

public class ThrowDie : MonoBehaviour
{
    public int maxNumberDie;

    public Text amountText;
    public Text amountBonusText;

    int dieNumber;
    int bonus;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Die();
        }
    }

    public void Die()
    {
        UIManager[] uIManager = FindObjectsOfType<UIManager>();

        dieNumber = Random.Range(1, maxNumberDie + 1);
        amountText.text = "Amount: " + dieNumber.ToString();

        dieNumber += bonus;
        amountBonusText.text = "Amount Bonus: " + dieNumber.ToString();
    }

    public void SetBonus(int newBonus)
    {
        bonus = newBonus;
    }

    private void OnEnable()
    {
        BonusManager.bonusEvent += SetBonus;
    }

    private void OnDisable()
    {
        BonusManager.bonusEvent -= SetBonus;
    }
}
