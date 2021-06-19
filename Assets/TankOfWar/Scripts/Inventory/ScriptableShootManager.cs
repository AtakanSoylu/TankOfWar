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

        public void Shoot(Vector3 from,Vector3 direction)
        {
            RaycastHit hit;
            var physic = Physics.Raycast(from, direction,out hit);
            if (physic)
            {
                Debug.Log("Name:" + hit.transform.name);
            }

        }




    }
}