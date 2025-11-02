using UnityEngine;

// TODO: extend to accept steamed milk when dragged and dropped
public class EspressoWorkZoneController : MonoBehaviour
{
    private GameObject ingredientSource; // Shots or steamed milk
    [SerializeField] private GameObject espressoShotPrefab;

    void Start()
    {
    }

    public void BrewShot()
    {
        GameObject shot = Instantiate(espressoShotPrefab, gameObject.transform);
        shot.transform.SetParent(gameObject.transform.parent);
            shot.transform.localScale = new Vector3(1,1,1);
        // TODO: add tracking if this is still here or removed? i.e. block brewing while shot exists here
    }
}
