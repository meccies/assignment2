using UnityEngine;

public class CameraFollowRigid : MonoBehaviour
{
        public Transform target;
        public Vector3 offset = new Vector3(0, 1, -10);

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position + offset;
        transform.LookAt(target);
    }
}
