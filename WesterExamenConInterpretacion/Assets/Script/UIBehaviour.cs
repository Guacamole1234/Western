using TMPro;
using UnityEngine;

public class UIBehaviour : MonoBehaviour
{
    public static UIBehaviour instance;
    
    [SerializeField] GameObject[] characterObjects;
    [SerializeField] GameObject[] positionTargets;

    [SerializeField] private float gameDuration;
    private float gameTimer;

    [SerializeField] private float minTimeToSpawn;
    [SerializeField] private float maxTimeToSpawn;
    private float currentRandomTime;

    private int currentPoints;

    private int triesToFindTarget = 40;

    [SerializeField] private TextMeshProUGUI currentTimerText;
    [SerializeField] private TextMeshProUGUI currentPointsText;

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
        for (int i = 0; i < characterObjects.Length; i++)
        {
            characterObjects[i].SetActive(false);
        }

        for (int i = 0; i < positionTargets.Length; i++)
        {
            positionTargets[i].SetActive(true);
        }

        gameTimer = gameDuration;
        currentRandomTime = Random.Range(minTimeToSpawn, maxTimeToSpawn);
    }

    private void Update()
    {
        if (MenuBehaviour.instance.gameStarted == true)
        {
            gameTimer -= Time.deltaTime;
            currentTimerText.text = gameTimer.ToString("00");

            if (gameTimer <= 0f)
            {
                MenuBehaviour.instance.gameStarted = false;
                MenuBehaviour.instance.ShowEndScreen(currentPoints);
            }

            currentRandomTime -= Time.deltaTime;
            if (currentRandomTime <= 0f)
            {
                currentRandomTime = Random.Range(minTimeToSpawn, maxTimeToSpawn);
                SpawnCharacter();
            }
        }
    }

    private void SpawnCharacter()
    {      
        GameObject selectedCharacter = null;
        
        //Selecciona objeto a activar.

        int randomCharacter = Random.Range(0, characterObjects.Length);

        for (int i = 0; i < triesToFindTarget; i++)
        {
            if (characterObjects[randomCharacter].activeSelf == false)
            {
                selectedCharacter = characterObjects[randomCharacter];

                break;
            }
            else
            {
                randomCharacter = Random.Range(0, characterObjects.Length);
            }
        }

        //Selecciona posición a asignar.

        int randomPosition = Random.Range(0, positionTargets.Length);

        for (int i = 0; i < triesToFindTarget; i++)
        {
            
            if (positionTargets[randomPosition].activeSelf == true)
            {
                selectedCharacter.transform.position = positionTargets[randomPosition].transform.position;

                selectedCharacter.GetComponent<BadGuyBehaviour>().currentTarget = positionTargets[randomPosition].gameObject;

                selectedCharacter.SetActive(true);
                positionTargets[randomPosition].SetActive(false);

                break;
            }
            else
            {
                randomPosition = Random.Range(0, positionTargets.Length);
            }
        }
    }

    public void AddPoints(int amountToAdd)
    {
        currentPoints += amountToAdd;
        currentPointsText.text = currentPoints.ToString() + " S";
    }
}
