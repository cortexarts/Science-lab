using UnityEngine;

public class Fusion : MonoBehaviour
{
    public GameObject PopUp;
    public GameObject Gunpowder;
    public GameObject Hydrogenperoxide;
    public GameObject Energy;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Fire" && gameObject.name == "Potassiumnitrate") //Create Charcoal
        {
                Gunpowder.transform.position = gameObject.transform.position;
                Instantiate(Gunpowder, new Vector2(Gunpowder.transform.position.x, Gunpowder.transform.position.y), Quaternion.identity);
                Destroy(col.gameObject);
                Destroy(gameObject);
        }
        else if (col.gameObject.name == "Hydrogen" && gameObject.name == "Oxygen") //Create Hydrogen peroxide and energy
        {
            Hydrogenperoxide.transform.position = gameObject.transform.position;
            Vector3 Energyposition = transform.position;
            Energyposition.x += 90;
            Energy.transform.position = Energyposition;
            Instantiate(Hydrogenperoxide, new Vector2(Hydrogenperoxide.transform.position.x, Hydrogenperoxide.transform.position.y), Quaternion.identity);
            Instantiate(Energy, new Vector2(Energy.transform.position.x, Energy.transform.position.y), Quaternion.identity);
            Destroy(col.gameObject);
            Destroy(gameObject);
            PopUp.SetActive(true);
        }
    }
}