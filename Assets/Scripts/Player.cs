using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;

    public float runSpeed = 20.0f;

    public Transform shootPoint;
    public GameObject bullet;
    public float shootRate;
    public float bulletSpeed;
    private bool canShoot;

    void Awake()
    {
        canShoot = true;
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical"); 

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

    void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0)
        {
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }

        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
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
