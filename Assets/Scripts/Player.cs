
using UnityEngine;

public class Player : Person
{
    [field: SerializeField] public int Experience { get; private set; }
    
    // Start is called before the first frame update
    void Start()
    {
        ShowStat();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Experience: {Experience}");
    }
}
