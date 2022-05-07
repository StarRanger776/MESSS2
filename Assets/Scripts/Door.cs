using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int _doorNumber;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            if (_doorNumber == 1 && collision.GetComponent<KnightMovement>()._hasRedKey)
            {
                collision.GetComponent<KnightMovement>()._hasRedKey = false;
                Destroy(this.gameObject);
            }
            else if (_doorNumber == 2 && collision.GetComponent<KnightMovement>()._hasGreenKey)
            {
                collision.GetComponent<KnightMovement>()._hasGreenKey = false;
                Destroy(this.gameObject);
            }
            else if (_doorNumber == 3 && collision.GetComponent<KnightMovement>()._hasBlueKey)
            {
                collision.GetComponent<KnightMovement>()._hasBlueKey = false;
                Destroy(this.gameObject);
            }
        }
    }
}
