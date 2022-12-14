using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sector : MonoBehaviour
{
    public bool Win = true;
    public Material GoodMaterial;
    public Material BadMaterial;

    private void Awake ()
    {
        UpdateMaterial();
    }

    private void UpdateMaterial()
    {
        Renderer sectorRender = GetComponent<Renderer>();
        sectorRender.sharedMaterial = Win ? GoodMaterial : BadMaterial;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.TryGetComponent(out Gamer gamer)) return;

        Vector3 normal = -collision.contacts[0].normal.normalized;
        float dot = Vector3.Dot(normal, Vector3.up);
        if (dot < 0.5) return;
        
        if (Win)
            gamer.Bounce();
        else
            gamer.Die();
    }
    private void OnValidate ()
    {
        UpdateMaterial();
    }
}
