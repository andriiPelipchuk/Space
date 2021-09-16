using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderPosition : MonoBehaviour
{
    [SerializeField] GameObject borderLeft;
    [SerializeField] GameObject borderRight;
    [SerializeField] GameObject playerBorderRight;
    [SerializeField] GameObject playerBorderLeft;
    public Camera mainCamera;
    private Vector3 minXPos;
    private Vector3 maxXPos;

    private void OnEnable()
    {
        minXPos = mainCamera.ViewportToWorldPoint(new Vector3(0, 0));
        maxXPos = mainCamera.ViewportToWorldPoint(new Vector3(1, 1));
        borderLeft.transform.position = new Vector3(minXPos.x - 0.6f, borderLeft.transform.position.y, 0);
        borderRight.transform.position = new Vector3(maxXPos.x + 0.6f, borderRight.transform.position.y, 0);
        playerBorderLeft.transform.position = new Vector3(minXPos.x - 0.6f, playerBorderLeft.transform.position.y, 0);
        playerBorderRight.transform.position = new Vector3(maxXPos.x + 0.6f, playerBorderRight.transform.position.y, 0);
    }
}
