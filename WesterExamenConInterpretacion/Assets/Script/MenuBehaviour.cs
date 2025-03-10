using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBehaviour : MonoBehaviour
{
    public static MenuBehaviour instance;

    [HideInInspector] public bool gameStarted = false;

    [SerializeField] private GameObject startCanvas;
    [SerializeField] private GameObject endScreenCanvas;

    [SerializeField] private TextMeshProUGUI finalPointsText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        startCanvas.SetActive(true);
        endScreenCanvas.SetActive(false);
    }

    public void StartGame()
    {
        gameStarted = true;
        startCanvas.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ShowEndScreen(int finalPoints)
    {
        finalPointsText.text = finalPoints.ToString() + " S";

        endScreenCanvas.SetActive(true);
    }
}
