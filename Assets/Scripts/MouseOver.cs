using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MouseOver : MonoBehaviour
{
    public ParticleSystem ps;
    public Material particleMaterial;

    Color m_MouseOverColor = new Color(1, 1, 1, .5f);
    Color m_OriginalColor;

    public GameObject farmLand;

    MeshRenderer m_Renderer;

    void Start()
    {
        m_Renderer = GetComponent<MeshRenderer>();
        m_OriginalColor = m_Renderer.material.color;
    }

    // Unity functions :3
    void OnMouseOver()
    {
        // Indicates currently selected block by changing color to red
        m_Renderer.material.color = m_MouseOverColor;

        // Replaces selected block with farmland
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 position = gameObject.transform.position;
            position.Set(position.x, position.y - 0.1f, position.z);
            Quaternion rotation = gameObject.transform.rotation;

            Instantiate(farmLand, position, rotation, gameObject.transform.parent);
            particlesEffects(position, rotation);
            Destroy(gameObject);
        }
    }

    void OnMouseExit()
    {
        m_Renderer.material.color = m_OriginalColor;
    }

    void particlesEffects(Vector3 position, Quaternion rotation)
    {
        // Particles will have same texture as the block being destroyed/modified (like minecraft)
        ps.GetComponent<ParticleSystemRenderer>().material = particleMaterial;

        Instantiate(ps, position, rotation, gameObject.transform.parent);
    }
}