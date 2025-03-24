using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Day Length Settings")]
    [Tooltip("Time in seconds for a full day cycle")]
    [SerializeField] private float dayLengthInSeconds = 60f;

    private float rotationSpeed;

    void Start()
    {
        // 360 degrees per full cycle divided by the length of the day
        rotationSpeed = 360f / dayLengthInSeconds;
    }

    void Update()
    {
        // Rotate the light around the X-axis (commonly used for sun movement)
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
