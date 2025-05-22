using UnityEngine;

public class Robot : MonoBehaviour
{
    [SerializeField]
    RobotStats stats;

    [SerializeField]
    Rigidbody2D body;

    [SerializeField]
    bool startAsActiveBot;

    [SerializeField]
    bool isActiveBot;

    [SerializeField]
    GameEventGeneric<RobotAndAbility> onAbilityUsed;

    [SerializeField]
    GameEventGeneric<Vector3> onDestroyed;

    [SerializeField]
    GameEventGeneric<Transform> onChangeCameraFocus;



    Vector2 movementVector;

    public bool StartAsActiveBot { get => startAsActiveBot; }
    public bool IsActiveBot
    {
        get => isActiveBot;
        set
        {
            isActiveBot = value;
            if (!isActiveBot)
            {
                movementVector = Vector2.zero;
            }
            else
            {
                onChangeCameraFocus.Invoke(transform);
            }
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveRobot(Vector2 move)
    {
        if (!isActiveBot)
        {
            return;
        }
        movementVector = move;
        movementVector.y = 0;
    }

    public void Jump()
    {
        if (!isActiveBot)
        {
            return;
        }
        if (stats.JumpHeight > 0)
        {
            body.AddForce(Vector2.up * stats.JumpHeight, ForceMode2D.Impulse);
        }
    }

    void FixedUpdate()
    {
        if (movementVector != Vector2.zero)
        {
            body.MovePosition((Vector2)transform.position + movementVector * stats.Speed * Time.fixedDeltaTime);
        }
    }

    public void UseAbility()
    {
        foreach (var ability in stats.Abilities)
        {
            if (!ability.IsPassive)
            {
                onAbilityUsed.Invoke(new RobotAndAbility() { Robot = this, Ability = ability });
            }
        }
    }

    public void Kill()
    {
        onDestroyed.Invoke(transform.position);
        gameObject.SetActive(false);
    }

    public bool IsImmuneToDamage(DamageType damageType)
    {
        return stats.Invulnerablities.Contains(damageType);
    }
}
