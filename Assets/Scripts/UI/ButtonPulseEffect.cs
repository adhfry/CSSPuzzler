using UnityEngine;

public class ButtonPulseEffect : MonoBehaviour
{
    public float pulseSpeed = 1.2f;   // kecepatan animasi
    public float scaleAmount = 1.05f; // seberapa besar tombol mengembang
    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        float scale = 1 + Mathf.Sin(Time.time * pulseSpeed) * (scaleAmount - 1);
        transform.localScale = originalScale * scale;
    }
}
