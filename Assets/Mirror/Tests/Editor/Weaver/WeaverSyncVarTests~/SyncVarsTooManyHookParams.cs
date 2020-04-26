using UnityEngine;
using Mirror;

namespace MirrorTest
{
    class SyncVarsTooManyHookParams : NetworkBehaviour
    {
        [SyncVar(hook = nameof(OnChangeHealth))]
        int health;

        public void TakeDamage(int amount)
        {
            if (!IsServer)
                return;

            health -= amount;
        }

        void OnChangeHealth(int oldHealth, int newHealth, int extraFunParameter)
        {
            // do things with your health bar
        }
    }
}
