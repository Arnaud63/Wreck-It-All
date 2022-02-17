using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGunCoolDown
{
    public abstract void StartCoolDown(float delay);
    public abstract void EndCoolDown();
    public abstract void WaitDelay(float delay);
}
