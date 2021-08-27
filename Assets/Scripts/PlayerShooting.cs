using System.Collections;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
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
        if (Input.GetKey(KeyCode.Space) && recharge)
        {
            recharge = false;
            Instantiate(projectile, gun.position, Quaternion.identity);
            StartCoroutine(Recharge());
        }
    }

    private IEnumerator Recharge()
    {
        yield return new WaitForSeconds(1);
        recharge = true;
    }
}
