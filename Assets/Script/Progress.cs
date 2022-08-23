
using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
    public Gamer Gamer;
    public Transform FinishPlatform;
    public Slider Slider;
    public float AFPDistance = 1f;

    private float _startY;
    private float _minimumReachedY;

    private void Start()
    {
        _startY = Gamer.transform.position.y;
    }

    private void Update()
    {
        _minimumReachedY = Mathf.Min(_minimumReachedY, Gamer.transform.position.y);
        float currentY = Gamer.transform.position.y;
        float finishY = FinishPlatform.transform.position.y;
        float t = Mathf.InverseLerp(_startY,finishY+ AFPDistance, _minimumReachedY);
        Slider.value = t;
    }
}
