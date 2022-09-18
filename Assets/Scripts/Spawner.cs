using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public List<GameObject> weapons;

    public InputField inputField;

    public Transform spawnPositionWeapon;

    void Start()
    {
        weapons = new List<GameObject>(Resources.LoadAll<GameObject>("Prefabs"));
    }

    public void ReadWeaponInputField()
    {

        foreach (GameObject weapon in weapons)
        {
            if(inputField.text == weapon.name)
            {
                Instantiate(weapon, spawnPositionWeapon.position, transform.rotation);
            }
        }
    }
}
