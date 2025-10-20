using UnityEngine;

public class InfinitySpace : MonoBehaviour
{
    public float speed; // Velocidade do movimento
    private Renderer renderization;
    private Vector2 savedOffset;

    void Start()
    {
        renderization = GetComponent<Renderer>();
        savedOffset = renderization.sharedMaterial.GetTextureOffset("_MainTex");
    }

    void Update()
    {
        float x = Mathf.Repeat(Time.time * speed, 1);
        Vector2 offset = new Vector2(x, savedOffset.y);
        renderization.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}