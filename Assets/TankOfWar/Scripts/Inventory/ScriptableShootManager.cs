using System.Collections;
using UnityEngine;

namespace TankOfWar.Inventory
{
    [CreateAssetMenu(menuName = "TankOfWar/Inventory/ScriptableShootManager")]
    public class ScriptableShootManager : AbstractScriptableManager<ScriptableShootManager>
    {
        public override void Initialize()
        {
            base.Initialize();
            Debug.Log("Scriptable shoot manager active");
        }
        public override void Destroy()
        {
            base.Initialize();
            Debug.Log("Scriptable shoot manager destroy");
            
        }

    }
}