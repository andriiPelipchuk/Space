using System.Collections;
using UnityEngine;

public class EnemyShoting : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] Transform gun;

    private bool recharge = true;

    private void Update()
    {
        Fire();
    }

    private void Fire()
    {
        Ray ray = new Ray(transform.position, new Vector3(transform.position.x, -10, 0) - transform.position);
        Physics.Raycast(ray, out RaycastHit hit);
        if (hit.collider != null) 
        {
            if (hit.collider.gameObject.tag == "Player" && recharge)
            {
                recharge = false;
                Instantiate(projectile, gun.position, new Quaternion(0, 0, -90, 0));
                StartCoroutine(Recharge());
            }
        }
    }

    private IEnumerator Recharge()
    {
        yield return new WaitForSeconds(3);
        recharge = true;
    }
}
