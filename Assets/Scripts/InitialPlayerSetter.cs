using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class InitialPlayerSetter : MonoBehaviour
{
    PlayerSpark spark;

    List<Robot> robots;

    void Start()
    {
        spark = GameObject.FindAnyObjectByType<PlayerSpark>();
        robots = GameObject.FindObjectsByType<Robot>(FindObjectsInactive.Include, FindObjectsSortMode.None).ToList();

        var initialBots = robots.Where(x => x.StartAsActiveBot).ToList();

        if (initialBots.Count > 1)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("More than one robot set to be active at start. This messes with stuff");
            foreach (var bot in initialBots)
            {
                sb.Append(bot.gameObject.name + "\r\n");
            }
            Debug.LogError(sb.ToString());
        }

        if (initialBots.Count == 0)
        {
            spark.Activate(spark.transform.position);
        }
        else
        {
            spark.gameObject.SetActive(false);
        }

        if (initialBots.Count != 0)
        {
            initialBots[0].IsActiveBot = true;
        }
    }

    public void ActivateSpark()
    {
        if (!spark.gameObject.activeInHierarchy)
        {
            var activeBot = robots.Where(x => x.IsActiveBot);
            if (activeBot.Count() > 0)
            {
                spark.Activate(activeBot.First().transform.position);
                activeBot.First().IsActiveBot = false;
            }
        }
    }
}