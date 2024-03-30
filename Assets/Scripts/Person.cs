using UnityEngine;

abstract class Person : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private float _health;
    [SerializeField] private int _damage;
    [SerializeField] private Person obj;

    public string Name
    {
        get { return _name; }
        private set { _name = value; }
    }

    public float Health
    {
        get 
        { 
            return _health;
        } 
        set 
        {
            if (value >= 0 && value <= 100)
                _health = value;
            else Debug.Log("Wrong value!"); 
        }
    }

    public int Damage
    {
        get
        {
            return _damage;
        }
        set
        {
            if (value >= 0 && value <= 1000)
                _damage = value;
            else Debug.Log("Wrong value!");
        }
    }



    public virtual void ShowStat()
    {
        Debug.Log($"Name: {Name}");
    }

    public abstract void TakeDamage(int damageValue);

    protected void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Floor")
            TakeDamage(collision.gameObject.GetComponent<Person>().Damage);
    }

}
