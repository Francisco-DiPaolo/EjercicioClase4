using System.Collections;
using UnityEngine;

public class Revolver : MonoBehaviour
{
    public int amountBullets;
    public int maxAmountBullets;

    public float timeToWait;

    bool cancelReload;

    void Update()
    {
        Shooting();

        if (Input.GetKeyDown("r"))
        {
            Reload();
        }
    }

    void Shooting()
    {
        if (Input.GetMouseButtonDown(0) && amountBullets > 0)
        {
            cancelReload = true;
            amountBullets -= 1;
            Debug.Log(amountBullets);

            if (amountBullets == 0)
            {
                Reload();
            }
        }
    }

    void Reload()
    {
        if (amountBullets < 6)
        {
            Debug.Log("Reloading");
            StartCoroutine(RoutineReload());
        }
    }

    IEnumerator RoutineReload()
    {
        cancelReload = false;

        while (amountBullets < maxAmountBullets)
        {

            yield return new WaitForSeconds(timeToWait);

            if (!cancelReload)
            {
                amountBullets += 1;
                Debug.Log("Reloading " + amountBullets);
            }
            else
            {
                Debug.Log("Reloading was cancel");
                break;
            }
        }
    }
}
