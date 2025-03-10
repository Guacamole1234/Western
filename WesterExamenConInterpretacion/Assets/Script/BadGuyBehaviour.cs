using UnityEngine;

public class BadGuyBehaviour : MonoBehaviour
{
    [SerializeField] private float timeActive;
    private float currentTimer;

    public int pointsToGive;

    [HideInInspector] public GameObject currentTarget;

    private void OnEnable()
    {
        currentTimer = timeActive;
    }

    private void Update()
    {
        currentTimer -= Time.deltaTime;
        if (currentTimer <= 0f)
        {
            DisableObject();
        }
    }

    public void DisableObject()
    {
        currentTarget.SetActive(true);
        gameObject.SetActive(false);
    }

    public void Clicked()
    {
        UIBehaviour.instance.AddPoints(pointsToGive);
        DisableObject();
    }
}
