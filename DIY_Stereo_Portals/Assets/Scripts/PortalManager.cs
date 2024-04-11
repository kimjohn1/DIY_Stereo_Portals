using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalManager : MonoBehaviour
{
    public Transform GreenPos;
    public Transform PinkPos;

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("GreenVRPortal"))
        {
            CharacterController cc = GetComponent<CharacterController>();

            cc.enabled = false;
            transform.position = PinkPos.transform.position;
            transform.rotation = new Quaternion(transform.rotation.x, PinkPos.rotation.y, transform.rotation.z, transform.rotation.w);

            cc.enabled = true;
        }

        if (col.CompareTag("PinkVRPortal"))
        {
            CharacterController cc = GetComponent<CharacterController>();

            cc.enabled = false;
            transform.position = GreenPos.transform.position;
            transform.rotation = new Quaternion(transform.rotation.x, GreenPos.rotation.y, transform.rotation.z, transform.rotation.w);

            cc.enabled = true;
        }
    }
}
