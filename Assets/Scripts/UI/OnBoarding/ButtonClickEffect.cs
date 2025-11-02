using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonClickEffect : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private Vector3 originalScale;
    public float pressScale = 0.95f;  // ukuran saat ditekan
    public float animationSpeed = 10f;

    void Start()
    {
        originalScale = transform.localScale;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        StopAllCoroutines();
        StartCoroutine(ScaleTo(originalScale * pressScale));
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        StopAllCoroutines();
        StartCoroutine(ScaleTo(originalScale));
    }

    System.Collections.IEnumerator ScaleTo(Vector3 target)
    {
        while (Vector3.Distance(transform.localScale, target) > 0.001f)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, target, Time.deltaTime * animationSpeed);
            yield return null;
        }
    }
}
