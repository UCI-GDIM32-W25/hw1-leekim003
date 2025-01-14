using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;
         
    private void Start ()
    {
         _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;

        if (_plantCountUI != null)
        {
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        }

    }

    private void Update()
    {
       
    // Get input for horizontal (X-axis) and vertical (Y-axis) movement
    float moveX = Input.GetAxis("Horizontal"); // Left/Right movement
    float moveY = Input.GetAxis("Vertical");   // Up/Down movement

    // Debugging input values
    Debug.Log($"Horizontal Input (X): {moveX}, Vertical Input (Y): {moveY}");

    // Create a movement vector for X and Y axes (no Z-axis movement)
    Vector3 movement = new Vector3(moveX, moveY, 0) * _speed * Time.deltaTime;

    // Apply the movement to the player's Transform
    _playerTransform.Translate(movement, Space.World);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        if (_numSeedsLeft > 0)
        {
            Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);

            // Update seed counts
            _numSeedsLeft--;
            _numSeedsPlanted++;

            // Update the UI
            if (_plantCountUI != null)
            {
                _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
            }
        }
        else
        {
            Debug.Log("No seeds left to plant!");
        }
    }
}
