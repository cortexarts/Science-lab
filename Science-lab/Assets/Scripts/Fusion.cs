using UnityEngine;

public class Fusion : MonoBehaviour
{
    public GameObject Gunpowder;

    void OnTriggerEnter2D(Collider2D col)
    {
            if (col.gameObject.name == "Fire" && gameObject.name == "Potassiumnitrate")
            {
                Gunpowder.transform.position = gameObject.transform.position;
                Instantiate(Gunpowder, new Vector2(Gunpowder.transform.position.x, Gunpowder.transform.position.y), Quaternion.identity);
                Destroy(col.gameObject);
                Destroy(gameObject);
        }
     }
}