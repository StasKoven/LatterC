using UnityEngine;
using DG.Tweening; // Підключення DoTween

public class RotateAndScale : MonoBehaviour
{
    [SerializeField] private float rotationDuration = 1f; // Тривалість обертання
    [SerializeField] private Ease rotationEase = Ease.InOutBounce; // Тип кривої обертання
    [SerializeField] private float punchScaleIntensity = 1.5f; // Інтенсивність Punch Scale
    [SerializeField] private float punchScaleDuration = 0.5f; // Тривалість Punch Scale

    private void Update()
    {
        // Обертання кожного куба при натисканні кнопки 1
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log($"<color=green>Pressed button 1:</color> <color=blue>Rotating individual cubes</color>");
            RotateThisCube();
        }

        // Punch Scale для кожного куба при натисканні кнопки 2
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log($"<color=green>Pressed button 2:</color> <color=red>Punching scale on individual cubes</color>");
            ScaleThisCube();
        }
    }

    private void RotateThisCube()
    {
        // Обертаємо тільки цей куб
        transform.DORotate(new Vector3(0, 360, 0), rotationDuration, RotateMode.FastBeyond360)
            .SetEase(rotationEase);
    }

    private void ScaleThisCube()
    {
        // Застосовуємо Punch Scale тільки до цього куба
        transform.DOPunchScale(Vector3.one * punchScaleIntensity, punchScaleDuration);
    }
}
