using UnityEngine;

 class Player : Person
{
    [field:SerializeField] public int Experience { get; private set; }
    
    void Start()
    {
        ShowStat();
    }


    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Experience: {Experience}");
    }

    public override void TakeDamage(int damageValue)
    {
        Health -= damageValue;
        Debug.Log($"My name is:{Name} \nAfter hitting with force: {damageValue}. I have health: {Health}!");
    }
}
