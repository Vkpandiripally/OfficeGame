using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    private Transform charGun;

    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject reloadingText;

    public int maxAmmo = 10;
    private int currentAmmo;
    public float reloadTime = 1f;
    private bool isReloading = false;

    public float bulletForce = 20f;

    private enum WeaponType { Pistol, Shotgun }
    private WeaponType currentWeapon = WeaponType.Pistol;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // Different Weapons
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            currentWeapon = WeaponType.Pistol;
        } 
        else if (Input.GetKeyUp(KeyCode.Alpha2)) 
        {
            currentWeapon = WeaponType.Shotgun;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            if (currentWeapon == WeaponType.Pistol)
            {
                Shoot();
            }
            else if (currentWeapon == WeaponType.Shotgun)
            {
                FireShotgun();
            }
        }
    }

    void Shoot()
    {
        // Calculate the direction vector based on the rotation of the firePoint
        Vector2 shootDirection = firePoint.right; // Assuming the gun is initially facing right

        // Create the bullet
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        // Apply force to the bullet in the calculated direction
        rb.AddForce(shootDirection * bulletForce, ForceMode2D.Impulse);

        // Calculate the angle in degrees
        float angle = Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg;

        // Rotate the bullet sprite to match the direction it's moving
        bullet.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));

 
    }

    void FireShotgun()
    {
        int pelletCount = 3;
        float spreadAngle = 45f;

        // Base direction from the gun
        Vector2 baseDirection = firePoint.right;

        for (int i = 0; i < pelletCount; i++)
        {
            float spread = (i - (pelletCount - 1) / 2f) * spreadAngle;
            Quaternion pelletSpread = Quaternion.Euler(0, 0, spread);

            // Rotate fire direction
            Vector2 pelletDirection = pelletSpread * baseDirection;

            // Spawn pellet
            GameObject pellet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

            // Rotate the bullet to face the direction it's moving
            float angle = Mathf.Atan2(pelletDirection.y, pelletDirection.x) * Mathf.Rad2Deg;
            pellet.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));


            // Apply force to pellet
            Rigidbody2D rb = pellet.GetComponent<Rigidbody2D>();
            rb.AddForce(pelletDirection * bulletForce, ForceMode2D.Impulse);
        }
    }
}
