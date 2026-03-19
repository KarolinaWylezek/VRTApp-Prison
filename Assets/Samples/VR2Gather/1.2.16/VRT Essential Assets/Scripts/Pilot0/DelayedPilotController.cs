using UnityEngine;
using System.Collections;
using VRT.Pilots.Common;

namespace VRT.Pilots.Common
{
    public class DelayedPilotController : PilotController
    {
        [Tooltip("Seconds before automatically switching to next scene")]
        [SerializeField] private float autoAdvanceDelay = 30f;

        public override void Start()
        {
            base.Start(); // keeps fade-in and other base behaviour
            StartCoroutine(AutoAdvance());
        }

        private IEnumerator AutoAdvance()
        {
            yield return new WaitForSeconds(autoAdvanceDelay);
            LoadNewScene(); // uses NextSceneOnSessionEnd from Inspector
        }
    }
}