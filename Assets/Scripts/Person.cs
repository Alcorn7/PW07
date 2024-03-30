using UnityEngine;

public class Person : MonoBehaviour
{
    [field: SerializeField] public string Name {  get; private set; }
    [field: SerializeField] public float Health 
    {
        get 
        { 
            return Health;
        } 
        set 
        { 
            if (value >= 0 && value <= 100)
                Debug.Log("Wrong value!");
            else Health = value; 
        }
    }

    public virtual void ShowStat()
    {
        Debug.Log($"Name: {Name}");
    }
}
