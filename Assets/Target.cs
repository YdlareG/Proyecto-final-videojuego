using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] AudioClip acierto;
    public void Hit()
    {
        AudioSource.PlayClipAtPoint(acierto, Camera.main.transform.position);
        transform.position = TargetBounds.Instance.GetRandomPosition();
    }
}
