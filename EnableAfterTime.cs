// Copyright (c) 2015 Bartlomiej Wolk (bartlomiejwolk@gmail.com)
// 
// This file is part of the EnableAfterTime extension for Unity. Licensed
// under the MIT license. See LICENSE file in the project root folder.

using UnityEngine;

namespace EnableAfterTimeEx {

    // todo move comments to properties
    public class EnableAfterTime : MonoBehaviour {

        #region CONSTANTS

        public const string Version = "v0.1.0";
        public const string Extension = "EnableAfterTime";

        #endregion

        #region FIELDS

#pragma warning disable 0414
        /// <summary>
        ///     Allows identify component in the scene file when reading it with
        ///     text editor.
        /// </summary>
        [SerializeField]
        private string componentName = "EnableAfterTime";
#pragma warning restore0414

        #endregion

        #region INSPECTOR FIELDS
        /// Game object to disable.
        [SerializeField]
        private GameObject targetGO;

        /// Delay before disabling the target game object.
        [SerializeField]
        private float delay;


        [SerializeField]
        private string description = "Description";

        #endregion

        #region PROPERTIES

        /// Delay before disabling the target game object.
        public float Delay {
            get { return delay; }
            set { delay = value; }
        }

        /// Game object to disable.
        public GameObject TargetGO {
            get { return targetGO; }
            set { targetGO = value; }
        }

        public string Description {
            get { return description; }
            set { description = value; }
        }

        #endregion

        #region UNITY MESSAGES

        private void Start() {
            if (!TargetGO) {
                Utilities.MissingReference(this, "target");
            }

            Invoke("EnableTargetGO", Delay);
        }

        #endregion

        #region METHODS
        private void EnableTargetGO() {
            TargetGO.SetActive(true);
        }

        #endregion

    }

}