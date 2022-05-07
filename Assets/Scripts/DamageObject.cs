using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour
{
    
    public int damage;
    public float _bufferTime;
    
    private bool _canBeDamaged = true;

    private void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Player")
        {
            if (_canBeDamaged == true)
            {
                Debug.Log("OUCH!");
                collision.GetComponent<KnightMovement>().TakeDamage(damage);
                _canBeDamaged = false;
                StartCoroutine(DamageBuffer());
            }
        }
    }

    private IEnumerator DamageBuffer()
    {
        yield return new WaitForSeconds(_bufferTime);
        _canBeDamaged = true;
    }
    
}
