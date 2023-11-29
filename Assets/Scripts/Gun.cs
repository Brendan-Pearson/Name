using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float fireRate = 0.1f;

    public int maxAmmo = 30;
    private int currentAmmo;
    public float reloadTime = 1f;
    private bool isReloading = false;

    public AudioSource gunshotSound;

    private float nextTimeToFire = 0f;

    private void Start()
    {
        currentAmmo = maxAmmo;
    }

    private void Update()
    {
        if (isReloading) //restarts if the palyer is reloading
            return;

        if (currentAmmo <= 0)
        {
            StartCoroutine(Reload()); //running the reload
            return;
        }

        if (Input.GetMouseButtonDown && Time.time >= nextTimeToFire) //if player is pressing shoot button and delay between shots is over
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }

    private void Shoot()
    {
        currentAmmo--; // looses ammo every shot

        // Play gunshot sound
        gunshotSound.Play();

        private void OnTriggerEnter(Collider other) //uses colliders to detect bullets
        {
            Health targetHealth = other.GetComponent<Health>();
            if (targetHealth != null)
            {
                // Deal damage to the enemy
                targetHealth.TakeDamage(damage);
            }
        }
    }

    private IEnumerator Reload()
    {
        isReloading = true; //starts re-load

        // Play reload sound 

        yield return new WaitForSeconds(reloadTime);

        currentAmmo = maxAmmo;
        isReloading = false; ///ends re-load
    }
}
