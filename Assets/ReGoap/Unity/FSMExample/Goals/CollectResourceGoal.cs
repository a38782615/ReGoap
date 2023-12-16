using System;
using ReGoap.Core;
using Unity.Mathematics;
using Random = Unity.Mathematics.Random;

namespace ReGoap.Unity.FSMExample.Goals
{
    public class CollectResourceGoal : ReGoapGoal<string, object>
    {
        public string ResourceName;

        protected override void Awake()
        {
            base.Awake();
            goal.Set("collectedResource" + ResourceName, true);
            goal.Set("reconcilePosition", true);
        }

        public override float GetPriority()
        {
            return Priority;
        }
        
        public override string ToString()
        {
            return string.Format("GoapGoal('{0}', '{1}')", Name, ResourceName);
        }
    }
}

