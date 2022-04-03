using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private const double smoothingSpeed = 0.005;
    public Transform target;
    private float smoothing = (float)smoothingSpeed;

    // Start is called before the first frame update
    private void Start()
    {
    }

    private void LateUpdate()
    {
        if (transform.position != target.position)
        {
            // create a vector which contains the target position but keeps z fixed
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);

            //
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }
    }
}