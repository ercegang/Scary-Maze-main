using UnityEngine;

public class Player : MonoBehaviour
{
    private bool shouldFollowMouse = false;

    void Update()
    {
        if (shouldFollowMouse)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z);
        }
        else if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            shouldFollowMouse = true;
        }
    }
}
