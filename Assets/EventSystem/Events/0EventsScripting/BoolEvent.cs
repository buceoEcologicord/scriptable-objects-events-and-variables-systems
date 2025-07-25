using UnityEngine;

//Based on Dapper Dino Scriptable Object Event System
//https://www.youtube.com/watch?v=iXNwWpG7EhM
//https://www.youtube.com/watch?v=P-U7GPXMtLY

namespace ScriptableObjects.Events
{
    [CreateAssetMenu(fileName = "Bool Event", menuName = "Game Events/Bool")]
    public class BoolEvent : BaseGameEvent<bool> { }
}
