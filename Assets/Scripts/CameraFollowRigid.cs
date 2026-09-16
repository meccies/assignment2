using UnityEngine;

public class CameraFollowRigid : MonoBehaviour
{
    public class Transform;
    public Vector3 move = new Vector3(0,1,-10);
   
    void Start()
    {   
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position + offset;
        Transform.LookAt(target);
    }
}
