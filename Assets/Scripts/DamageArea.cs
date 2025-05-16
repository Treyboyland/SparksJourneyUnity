using System.Collections.Generic;
using UnityEngine;

public class DamageArea : MonoBehaviour
{
    [SerializeField]
    List<DamageType> damageTypes;

    bool IsBotImmune(Robot bot)
    {
        foreach (var damageType in damageTypes)
        {
            if (!bot.IsImmuneToDamage(damageType))
            {
                return false;
            }
        }

        return true;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.gameObject.GetComponent<Robot>();
        if (player != null && player.IsActiveBot)
        {
            if (!IsBotImmune(player))
            {
                player.Kill();
            }
        }
    }
}
