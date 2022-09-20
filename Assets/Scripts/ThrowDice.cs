using UnityEngine;
using UnityEngine.UI;

public class ThrowDice : MonoBehaviour
{
    public int maxNumberDie;
    public int numberBonus;

    public Text textAmountTotal;
    public Text textMod;

    int dice;

    bool boolNumberToggle;

    private void Start()
    {
        boolNumberToggle = false;
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Dice();
        }
    }

    public void Dice()
    {
        dice = Random.Range(1, maxNumberDie);
        Debug.Log(dice);
    }

    public void Toggle()
    {
        if (!boolNumberToggle)
        {
            maxNumberDie += numberBonus;
            boolNumberToggle = true;

            textAmountTotal.text = "Amount: " + maxNumberDie;
            textMod.text = "Mod: Flanking Mod";
        }
    }


    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }
}
