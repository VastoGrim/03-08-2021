using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject bullet;
    public float shootRate;
    public float bulletSpeed;
    private bool canShoot;

    void Awake()
    {
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 direction = new Vector3(
            mousePos.x - transform.position.x,
            mousePos.y - transform.position.y);

        transform.right = direction;

        if(Input.GetMouseButtonDown(0) && canShoot)
        {
            StartCoroutine(Shoot());
        }
    }

    public IEnumerator Shoot()
    {
        canShoot = false;
        GameObject tempBullet = Instantiate(bullet, shootPoint.position, shootPoint.rotation);
        Rigidbody2D rigidbody = tempBullet.GetComponent<Rigidbody2D>();
        rigidbody.AddForce(transform.right * bulletSpeed, ForceMode2D.Impulse);
        Destroy(tempBullet, 2);
        yield return new WaitForSeconds(shootRate);
        canShoot = true;

    }
}
