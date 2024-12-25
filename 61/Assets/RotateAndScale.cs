using UnityEngine;
using DG.Tweening;

public class RotateAndScale : MonoBehaviour
{
    [SerializeField] private float rotationDuration = 1f;
    [SerializeField] private Ease rotationEase = Ease.InOutBounce;
    [SerializeField] private float punchScaleIntensity = 1.5f;
    [SerializeField] private float punchScaleDuration = 0.5f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log($"<color=green>Pressed button 1:</color> <color=blue>Rotating individual cubes</color>");
            RotateThisCube();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log($"<color=green>Pressed button 2:</color> <color=red>Punching scale on individual cubes</color>");
            ScaleThisCube();
        }
    }

    private void RotateThisCube()
    {
        transform.DORotate(new Vector3(0, 360, 0), rotationDuration, RotateMode.FastBeyond360)
            .SetEase(rotationEase);
    }

    private void ScaleThisCube()
    {
        transform.DOPunchScale(Vector3.one * punchScaleIntensity, punchScaleDuration);
    }
}
