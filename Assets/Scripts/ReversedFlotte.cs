using System.Collections;
using UnityEngine;

public class ReversedFlotte : MonoBehaviour
{
    [SerializeField] FlotteMove flotte;
    private bool checkOnTouch = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (!checkOnTouch)
        {
            checkOnTouch = true;
            flotte.TurnMove();
            StartCoroutine(ChangeVariableCHeckOnTouch());
        }

    }
    private IEnumerator ChangeVariableCHeckOnTouch()
    {
        yield return new WaitForSeconds(0.2f);
        checkOnTouch = false;
    }
}
