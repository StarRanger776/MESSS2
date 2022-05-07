using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public int damage;
    public int range;
    //public int _maxAmmo;
    //public int _currAmmo;

    public Camera fpsCam;

    private void Start()
    {
        //_currAmmo = (int)(.75f * _maxAmmo);
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //if (_currAmmo > 0)
        //{
        //    --_currAmmo;
        //}

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            EnemyController target = hit.transform.GetComponent<EnemyController>();
            if (target != null)
            {
                hit.transform.GetComponent<EnemyController>().TakeDamage(damage);
            }
        }
    }
}