using System.Collections.Generic;
using UnityEngine;

public class PositionSwap : Monobehaviour
{
[SerializeField]
Vector3 trueDistanceAdd;

[SerializeField]
float secondsToMove;

[SerializeField]
bool initialState;

Vector3 startPos

void Start()
{
startPos = transform.position;
SetPos(initialState);
}

public void MovePos(bool val)
{
StopAllCoroutines();
StartCoroutine(MoveToPosition(val ? startPos + trueDistanceAdd : startPos));
}

public void SetPos(bool val)
{
StopAllCoroutines();
transform.position = val ? startPos + trueDistanceAdd : startPos;
}

IEnumerator MoveToPosition(Vector3 endPos)
{
float elapsed = 0;
Vector3 startPos = transform.position;
while(elapsed < secondsToMove)
{
transform.position = Vector3.Lerp(startPos, endPos, elapsed /secondsToMove);
yield return null; 
}

transform.position = endPos;
}
}