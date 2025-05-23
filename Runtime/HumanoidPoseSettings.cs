using System;
using UnityEngine;

namespace UnityEssentials
{
    /// <summary>
    /// Represents the settings and controls for configuring humanoid pose adjustments, including body, limbs, and
    /// facial features.
    /// </summary>
    /// <remarks>This class provides a comprehensive set of properties and methods to manipulate humanoid pose
    /// parameters, such as muscle movements, limb positions, and facial expressions. It includes event-driven updates
    /// to ensure changes are reflected in real-time.</remarks>
    [Serializable]
    public class HumanoidPoseSettings
    {
        public Action<int, float> SetMuscleEvent;

        public void OnDisable() =>
            SetMuscleEvent = null;

        #region // On Value Changed
        #region // Controls
        [OnValueChanged("Standing")]
        public void OnStandingChanged()
        {
            LeftForearmStretch = Standing;

            RightForearmStretch = Standing;

            LeftUpperLegFrontBack = Standing * 0.5f;
            LeftLowerLegStretch = Standing;

            RightUpperLegFrontBack = Standing * 0.5f;
            RightLowerLegStretch = Standing;

            OnLeftForearmStretchChanged();

            OnRightForearmStretchChanged();

            OnLeftUpperLegFrontBackChanged();
            OnLeftLowerLegStretchChanged();

            OnRightUpperLegFrontBackChanged();
            OnRightLowerLegStretchChanged();
        }

        [OnValueChanged("CurlInOut")]
        public void OnCurlInOutChanged()
        {
            SpineFrontBack = CurlInOut * 0.5f;
            ChestFrontBack = CurlInOut * 0.5f;
            UpperChestFrontBack = CurlInOut;
            NeckNodDownUp = CurlInOut;

            LeftShoulderDownUp = CurlInOut * 0.5f;
            LeftArmDownUp = CurlInOut * 0.5f;
            LeftForearmStretch = CurlInOut;

            RightShoulderDownUp = CurlInOut * 0.5f;
            RightArmDownUp = CurlInOut * 0.5f;
            RightForearmStretch = CurlInOut;

            LeftUpperLegFrontBack = CurlInOut;
            LeftUpperLegTwistInOut = CurlInOut * 0.5f * -1;
            LeftLowerLegStretch = CurlInOut;
            LeftLowerLegTwistInOut = CurlInOut * 0.25f * -1;
            LeftFootUpDown = CurlInOut * 0.5f;
            LeftToesUpDown = CurlInOut * 0.5f;
            LeftFingersStretch = CurlInOut;

            RightUpperLegFrontBack = CurlInOut;
            RightUpperLegTwistInOut = CurlInOut * 0.5f * -1;
            RightLowerLegStretch = CurlInOut;
            RightLowerLegTwistInOut = CurlInOut * 0.25f * -1;
            RightFootUpDown = CurlInOut * 0.5f;
            RightToesUpDown = CurlInOut * 0.5f;
            RightFingersStretch = CurlInOut;

            OnSpineFrontBackChanged();
            OnChestFrontBackChanged();
            OnUpperChestFrontBackChanged();
            OnNeckNodDownUpChanged();

            OnLeftShoulderDownUpChanged();
            OnLeftArmDownUpChanged();
            OnLeftForearmStretchChanged();

            OnRightShoulderDownUpChanged();
            OnRightArmDownUpChanged();
            OnRightForearmStretchChanged();

            OnLeftUpperLegFrontBackChanged();
            OnLeftUpperLegTwistInOutChanged();
            OnLeftLowerLegStretchChanged();
            OnLeftLowerLegTwistInOutChanged();
            OnLeftFootUpDownChanged();
            OnLeftToesUpDownChanged();
            OnLeftFingersStretchedChanged();

            OnRightUpperLegFrontBackChanged();
            OnRightUpperLegTwistInOutChanged();
            OnRightLowerLegStretchChanged();
            OnRightLowerLegTwistInOutChanged();
            OnRightFootUpDownChanged();
            OnRightToesUpDownChanged();
            OnRightFingersStretchedChanged();
        }

        [OnValueChanged("LeftFingersStretch")]
        public void OnLeftFingersStretchedChanged()
        {
            LeftThumbStretch = LeftFingersStretch;
            LeftIndexStretch = LeftFingersStretch;
            LeftMiddleStretch = LeftFingersStretch;
            LeftRingStretch = LeftFingersStretch;
            LeftLittleStretch = LeftFingersStretch;

            OnLeftThumbStretchChanged();
            OnLeftIndexStretchChanged();
            OnLeftMiddleStretchChanged();
            OnLeftRingStretchChanged();
            OnLeftLittleStretchChanged();
        }

        [OnValueChanged("LeftFingersSpread")]
        public void OnLeftFingersSpreadChanged()
        {
            LeftThumbSpread = LeftFingersSpread;
            LeftIndexSpread = LeftFingersSpread;
            LeftMiddleSpread = LeftFingersSpread;
            LeftRingSpread = LeftFingersSpread;
            LeftLittleSpread = LeftFingersSpread;

            OnLeftThumbSpreadChanged();
            OnLeftIndexSpreadChanged();
            OnLeftMiddleSpreadChanged();
            OnLeftRingSpreadChanged();
            OnLeftLittleSpreadChanged();
        }

        [OnValueChanged("RightFingersStretch")]
        public void OnRightFingersStretchedChanged()
        {
            RightThumbStretch = RightFingersStretch;
            RightIndexStretch = RightFingersStretch;
            RightMiddleStretch = RightFingersStretch;
            RightRingStretch = RightFingersStretch;
            RightLittleStretch = RightFingersStretch;

            OnRightThumbStretchChanged();
            OnRightIndexStretchChanged();
            OnRightMiddleStretchChanged();
            OnRightRingStretchChanged();
            OnRightLittleStretchChanged();
        }

        [OnValueChanged("RightFingersSpread")]
        public void OnRightFingersSpreadChanged()
        {
            RightThumbSpread = RightFingersSpread;
            RightIndexSpread = RightFingersSpread;
            RightMiddleSpread = RightFingersSpread;
            RightRingSpread = RightFingersSpread;
            RightLittleSpread = RightFingersSpread;

            OnRightThumbSpreadChanged();
            OnRightIndexSpreadChanged();
            OnRightMiddleSpreadChanged();
            OnRightRingSpreadChanged();
            OnRightLittleSpreadChanged();
        }
        #endregion

        #region // Core Body
        [OnValueChanged("SpineFrontBack")] public void OnSpineFrontBackChanged() => SetMuscleEvent((int)HumanBodyMuscles.SpineFrontBack, SpineFrontBack);
        [OnValueChanged("SpineLeftRight")] public void OnSpineLeftRightChanged() => SetMuscleEvent((int)HumanBodyMuscles.SpineLeftRight, SpineLeftRight);
        [OnValueChanged("SpineTwistLeftRight")] public void OnSpineTwistLeftRightChanged() => SetMuscleEvent((int)HumanBodyMuscles.SpineTwistLeftRight, SpineTwistLeftRight);

        [OnValueChanged("ChestFrontBack")] public void OnChestFrontBackChanged() => SetMuscleEvent((int)HumanBodyMuscles.ChestFrontBack, ChestFrontBack);
        [OnValueChanged("ChestLeftRight")] public void OnChestLeftRightChanged() => SetMuscleEvent((int)HumanBodyMuscles.ChestLeftRight, ChestLeftRight);
        [OnValueChanged("ChestTwistLeftRight")] public void OnChestTwistLeftRightChanged() => SetMuscleEvent((int)HumanBodyMuscles.ChestTwistLeftRight, ChestTwistLeftRight);

        [OnValueChanged("UpperChestFrontBack")] public void OnUpperChestFrontBackChanged() => SetMuscleEvent((int)HumanBodyMuscles.UpperChestFrontBack, UpperChestFrontBack);
        [OnValueChanged("UpperChestLeftRight")] public void OnUpperChestLeftRightChanged() => SetMuscleEvent((int)HumanBodyMuscles.UpperChestLeftRight, UpperChestLeftRight);
        [OnValueChanged("UpperChestTwistLeftRight")] public void OnUpperChestTwistLeftRightChanged() => SetMuscleEvent((int)HumanBodyMuscles.UpperChestTwistLeftRight, UpperChestTwistLeftRight);
        #endregion

        #region // Head & Face
        [OnValueChanged("NeckNodDownUp")] public void OnNeckNodDownUpChanged() => SetMuscleEvent((int)HumanBodyMuscles.NeckNodDownUp, NeckNodDownUp);
        [OnValueChanged("NeckTiltLeftRight")] public void OnNeckTiltLeftRightChanged() => SetMuscleEvent((int)HumanBodyMuscles.NeckTiltLeftRight, NeckTiltLeftRight);
        [OnValueChanged("NeckTurnLeftRight")] public void OnNeckTurnLeftRightChanged() => SetMuscleEvent((int)HumanBodyMuscles.NeckTurnLeftRight, NeckTurnLeftRight);

        [OnValueChanged("HeadNodDownUp")] public void OnHeadNodDownUpChanged() => SetMuscleEvent((int)HumanBodyMuscles.HeadNodDownUp, HeadNodDownUp);
        [OnValueChanged("HeadTiltLeftRight")] public void OnHeadTiltLeftRightChanged() => SetMuscleEvent((int)HumanBodyMuscles.HeadTiltLeftRight, HeadTiltLeftRight);
        [OnValueChanged("HeadTurnLeftRight")] public void OnHeadTurnLeftRightChanged() => SetMuscleEvent((int)HumanBodyMuscles.HeadTurnLeftRight, HeadTurnLeftRight);

        [OnValueChanged("LeftEyeDownUp")] public void OnLeftEyeDownUpChanged() => SetMuscleEvent((int)HumanBodyMuscles.LeftEyeDownUp, LeftEyeDownUp);
        [OnValueChanged("LeftEyeInOut")] public void OnLeftEyeInOutChanged() => SetMuscleEvent((int)HumanBodyMuscles.LeftEyeInOut, LeftEyeInOut);
        [OnValueChanged("RightEyeDownUp")] public void OnRightEyeDownUpChanged() => SetMuscleEvent((int)HumanBodyMuscles.RightEyeDownUp, RightEyeDownUp);
        [OnValueChanged("RightEyeInOut")] public void OnRightEyeInOutChanged() => SetMuscleEvent((int)HumanBodyMuscles.RightEyeInOut, RightEyeInOut);

        [OnValueChanged("JawClose")] public void OnJawCloseChanged() => SetMuscleEvent((int)HumanBodyMuscles.JawClose, JawClose);
        [OnValueChanged("JawLeftRight")] public void OnJawLeftRightChanged() => SetMuscleEvent((int)HumanBodyMuscles.JawLeftRight, JawLeftRight);
        #endregion

        #region // Left Arm & Hand
        [OnValueChanged("LeftShoulderDownUp")] public void OnLeftShoulderDownUpChanged() => SetMuscleEvent((int)HumanBodyMuscles.LeftShoulderDownUp, LeftShoulderDownUp);
        [OnValueChanged("LeftShoulderFrontBack")] public void OnLeftShoulderFrontBackChanged() => SetMuscleEvent((int)HumanBodyMuscles.LeftShoulderFrontBack, LeftShoulderFrontBack);

        [OnValueChanged("LeftArmDownUp")] public void OnLeftArmDownUpChanged() => SetMuscleEvent((int)HumanBodyMuscles.LeftArmDownUp, LeftArmDownUp);
        [OnValueChanged("LeftArmFrontBack")] public void OnLeftArmFrontBackChanged() => SetMuscleEvent((int)HumanBodyMuscles.LeftArmFrontBack, LeftArmFrontBack);
        [OnValueChanged("LeftArmTwistInOut")]
        public void OnLeftArmTwistInOutChanged()
        {
            SetMuscleEvent((int)HumanBodyMuscles.LeftArmTwistInOut, LeftArmTwistInOut);

            OnLeftArmDownUpChanged();
            OnLeftArmFrontBackChanged();
            OnLeftForearmStretchChanged();
            OnLeftForearmTwistInOutChanged();
        }

        [OnValueChanged("LeftForearmStretch")] public void OnLeftForearmStretchChanged() => SetMuscleEvent((int)HumanBodyMuscles.LeftForearmStretch, LeftForearmStretch);
        [OnValueChanged("LeftForearmTwistInOut")] public void OnLeftForearmTwistInOutChanged() => SetMuscleEvent((int)HumanBodyMuscles.LeftForearmTwistInOut, LeftForearmTwistInOut);

        [OnValueChanged("LeftHandDownUp")] public void OnLeftHandDownUpChanged() => SetMuscleEvent((int)HumanBodyMuscles.LeftHandDownUp, LeftHandDownUp);
        [OnValueChanged("LeftHandInOut")] public void OnLeftHandInOutChanged() => SetMuscleEvent((int)HumanBodyMuscles.LeftHandInOut, LeftHandInOut);

        [OnValueChanged("LeftThumbStretch")]
        public void OnLeftThumbStretchChanged()
        {
            SetMuscleEvent((int)HumanBodyMuscles.LeftThumb1Stretched, LeftThumbStretch);
            SetMuscleEvent((int)HumanBodyMuscles.LeftThumb2Stretched, LeftThumbStretch);
            SetMuscleEvent((int)HumanBodyMuscles.LeftThumb3Stretched, LeftThumbStretch);
        }
        [OnValueChanged("LeftThumbSpread")] public void OnLeftThumbSpreadChanged() => SetMuscleEvent((int)HumanBodyMuscles.LeftThumbSpread, LeftThumbSpread);

        [OnValueChanged("LeftIndexStretch")]
        public void OnLeftIndexStretchChanged()
        {
            SetMuscleEvent((int)HumanBodyMuscles.LeftIndex1Stretched, LeftIndexStretch);
            SetMuscleEvent((int)HumanBodyMuscles.LeftIndex2Stretched, LeftIndexStretch);
            SetMuscleEvent((int)HumanBodyMuscles.LeftIndex3Stretched, LeftIndexStretch);
        }
        [OnValueChanged("LeftIndexSpread")] public void OnLeftIndexSpreadChanged() => SetMuscleEvent((int)HumanBodyMuscles.LeftIndexSpread, LeftIndexSpread);

        [OnValueChanged("LeftMiddleStretch")]
        public void OnLeftMiddleStretchChanged()
        {
            SetMuscleEvent((int)HumanBodyMuscles.LeftMiddle1Stretched, LeftMiddleStretch);
            SetMuscleEvent((int)HumanBodyMuscles.LeftMiddle2Stretched, LeftMiddleStretch);
            SetMuscleEvent((int)HumanBodyMuscles.LeftMiddle3Stretched, LeftMiddleStretch);
        }
        [OnValueChanged("LeftMiddleSpread")] public void OnLeftMiddleSpreadChanged() => SetMuscleEvent((int)HumanBodyMuscles.LeftMiddleSpread, LeftMiddleSpread);

        [OnValueChanged("LeftRingStretch")]
        public void OnLeftRingStretchChanged()
        {
            SetMuscleEvent((int)HumanBodyMuscles.LeftRing1Stretched, LeftRingStretch);
            SetMuscleEvent((int)HumanBodyMuscles.LeftRing2Stretched, LeftRingStretch);
            SetMuscleEvent((int)HumanBodyMuscles.LeftRing3Stretched, LeftRingStretch);
        }
        [OnValueChanged("LeftRingSpread")] public void OnLeftRingSpreadChanged() => SetMuscleEvent((int)HumanBodyMuscles.LeftRingSpread, LeftRingSpread);

        [OnValueChanged("LeftLittleStretch")]
        public void OnLeftLittleStretchChanged()
        {
            SetMuscleEvent((int)HumanBodyMuscles.LeftLittle1Stretched, LeftLittleStretch);
            SetMuscleEvent((int)HumanBodyMuscles.LeftLittle2Stretched, LeftLittleStretch);
            SetMuscleEvent((int)HumanBodyMuscles.LeftLittle3Stretched, LeftLittleStretch);
        }
        [OnValueChanged("LeftLittleSpread")] public void OnLeftLittleSpreadChanged() => SetMuscleEvent((int)HumanBodyMuscles.LeftLittleSpread, LeftLittleSpread);
        #endregion

        #region // Right Arm & Hand
        [OnValueChanged("RightShoulderDownUp")] public void OnRightShoulderDownUpChanged() => SetMuscleEvent((int)HumanBodyMuscles.RightShoulderDownUp, RightShoulderDownUp);
        [OnValueChanged("RightShoulderFrontBack")] public void OnRightShoulderFrontBackChanged() => SetMuscleEvent((int)HumanBodyMuscles.RightShoulderFrontBack, RightShoulderFrontBack);

        [OnValueChanged("RightArmDownUp")] public void OnRightArmDownUpChanged() => SetMuscleEvent((int)HumanBodyMuscles.RightArmDownUp, RightArmDownUp);
        [OnValueChanged("RightArmFrontBack")] public void OnRightArmFrontBackChanged() => SetMuscleEvent((int)HumanBodyMuscles.RightArmFrontBack, RightArmFrontBack);
        [OnValueChanged("RightArmTwistInOut")]
        public void OnRightArmTwistInOutChanged()
        {
            SetMuscleEvent((int)HumanBodyMuscles.RightArmTwistInOut, RightArmTwistInOut);

            OnRightArmDownUpChanged();
            OnRightArmFrontBackChanged();
            OnRightForearmStretchChanged();
            OnRightForearmTwistInOutChanged();
        }

        [OnValueChanged("RightForearmStretch")] public void OnRightForearmStretchChanged() => SetMuscleEvent((int)HumanBodyMuscles.RightForearmStretch, RightForearmStretch);
        [OnValueChanged("RightForearmTwistInOut")] public void OnRightForearmTwistInOutChanged() => SetMuscleEvent((int)HumanBodyMuscles.RightForearmTwistInOut, RightForearmTwistInOut);

        [OnValueChanged("RightHandDownUp")] public void OnRightHandDownUpChanged() => SetMuscleEvent((int)HumanBodyMuscles.RightHandDownUp, RightHandDownUp);
        [OnValueChanged("RightHandInOut")] public void OnRightHandInOutChanged() => SetMuscleEvent((int)HumanBodyMuscles.RightHandInOut, RightHandInOut);

        [OnValueChanged("RightThumbStretch")]
        public void OnRightThumbStretchChanged()
        {
            SetMuscleEvent((int)HumanBodyMuscles.RightThumb1Stretched, RightThumbStretch);
            SetMuscleEvent((int)HumanBodyMuscles.RightThumb2Stretched, RightThumbStretch);
            SetMuscleEvent((int)HumanBodyMuscles.RightThumb3Stretched, RightThumbStretch);
        }
        [OnValueChanged("RightThumbSpread")] public void OnRightThumbSpreadChanged() => SetMuscleEvent((int)HumanBodyMuscles.RightThumbSpread, RightThumbSpread);

        [OnValueChanged("RightIndexStretch")]
        public void OnRightIndexStretchChanged()
        {
            SetMuscleEvent((int)HumanBodyMuscles.RightIndex1Stretched, RightIndexStretch);
            SetMuscleEvent((int)HumanBodyMuscles.RightIndex2Stretched, RightIndexStretch);
            SetMuscleEvent((int)HumanBodyMuscles.RightIndex3Stretched, RightIndexStretch);
        }
        [OnValueChanged("RightIndexSpread")] public void OnRightIndexSpreadChanged() => SetMuscleEvent((int)HumanBodyMuscles.RightIndexSpread, RightIndexSpread);

        [OnValueChanged("RightMiddleStretch")]
        public void OnRightMiddleStretchChanged()
        {
            SetMuscleEvent((int)HumanBodyMuscles.RightMiddle1Stretched, RightMiddleStretch);
            SetMuscleEvent((int)HumanBodyMuscles.RightMiddle2Stretched, RightMiddleStretch);
            SetMuscleEvent((int)HumanBodyMuscles.RightMiddle3Stretched, RightMiddleStretch);
        }
        [OnValueChanged("RightMiddleSpread")] public void OnRightMiddleSpreadChanged() => SetMuscleEvent((int)HumanBodyMuscles.RightMiddleSpread, RightMiddleSpread);

        [OnValueChanged("RightRingStretch")]
        public void OnRightRingStretchChanged()
        {
            SetMuscleEvent((int)HumanBodyMuscles.RightRing1Stretched, RightRingStretch);
            SetMuscleEvent((int)HumanBodyMuscles.RightRing2Stretched, RightRingStretch);
            SetMuscleEvent((int)HumanBodyMuscles.RightRing3Stretched, RightRingStretch);
        }
        [OnValueChanged("RightRingSpread")] public void OnRightRingSpreadChanged() => SetMuscleEvent((int)HumanBodyMuscles.RightRingSpread, RightRingSpread);

        [OnValueChanged("RightLittleStretch")]
        public void OnRightLittleStretchChanged()
        {
            SetMuscleEvent((int)HumanBodyMuscles.RightLittle1Stretched, RightLittleStretch);
            SetMuscleEvent((int)HumanBodyMuscles.RightLittle2Stretched, RightLittleStretch);
            SetMuscleEvent((int)HumanBodyMuscles.RightLittle3Stretched, RightLittleStretch);
        }
        [OnValueChanged("RightLittleSpread")] public void OnRightLittleSpreadChanged() => SetMuscleEvent((int)HumanBodyMuscles.RightLittleSpread, RightLittleSpread);
        #endregion

        #region // Left Leg & Foot
        [OnValueChanged("LeftUpperLegFrontBack")] public void OnLeftUpperLegFrontBackChanged() => SetMuscleEvent((int)HumanBodyMuscles.LeftUpperLegFrontBack, LeftUpperLegFrontBack);
        [OnValueChanged("LeftUpperLegInOut")] public void OnLeftUpperLegInOutChanged() => SetMuscleEvent((int)HumanBodyMuscles.LeftUpperLegInOut, LeftUpperLegInOut);
        [OnValueChanged("LeftUpperLegTwistInOut", "RightUpperLegTwistInOut")]
        public void OnLeftUpperLegTwistInOutChanged()
        {
            SetMuscleEvent((int)HumanBodyMuscles.LeftUpperLegTwistInOut, LeftUpperLegTwistInOut);

            OnLeftUpperLegFrontBackChanged();
            OnLeftUpperLegInOutChanged();
            OnLeftLowerLegStretchChanged();
            OnLeftLowerLegTwistInOutChanged();
            OnLeftFootUpDownChanged();
            OnLeftFootTwistInOutChanged();
        }

        [OnValueChanged("LeftLowerLegStretch")] public void OnLeftLowerLegStretchChanged() => SetMuscleEvent((int)HumanBodyMuscles.LeftLowerLegStretch, LeftLowerLegStretch);
        [OnValueChanged("LeftLowerLegTwistInOut")] public void OnLeftLowerLegTwistInOutChanged() => SetMuscleEvent((int)HumanBodyMuscles.LeftLowerLegTwistInOut, LeftLowerLegTwistInOut);

        [OnValueChanged("LeftFootUpDown")] public void OnLeftFootUpDownChanged() => SetMuscleEvent((int)HumanBodyMuscles.LeftFootUpDown, LeftFootUpDown);
        [OnValueChanged("LeftFootTwistInOut")] public void OnLeftFootTwistInOutChanged() => SetMuscleEvent((int)HumanBodyMuscles.LeftFootTwistInOut, LeftFootTwistInOut);

        [OnValueChanged("LeftToesUpDown")] public void OnLeftToesUpDownChanged() => SetMuscleEvent((int)HumanBodyMuscles.LeftToesUpDown, LeftToesUpDown);
        #endregion

        #region // Right Leg & Foot
        [OnValueChanged("RightUpperLegFrontBack")] public void OnRightUpperLegFrontBackChanged() => SetMuscleEvent((int)HumanBodyMuscles.RightUpperLegFrontBack, RightUpperLegFrontBack);
        [OnValueChanged("RightUpperLegInOut")] public void OnRightUpperLegInOutChanged() => SetMuscleEvent((int)HumanBodyMuscles.RightUpperLegInOut, RightUpperLegInOut);
        [OnValueChanged("RightUpperLegTwistInOut", "LeftUpperLegTwistInOut")]
        public void OnRightUpperLegTwistInOutChanged()
        {
            SetMuscleEvent((int)HumanBodyMuscles.RightUpperLegTwistInOut, RightUpperLegTwistInOut);

            OnRightUpperLegFrontBackChanged();
            OnRightUpperLegInOutChanged();
            OnRightLowerLegStretchChanged();
            OnRightLowerLegTwistInOutChanged();
            OnRightFootUpDownChanged();
            OnRightFootTwistInOutChanged();
        }

        [OnValueChanged("RightLowerLegStretch")] public void OnRightLowerLegStretchChanged() => SetMuscleEvent((int)HumanBodyMuscles.RightLowerLegStretch, RightLowerLegStretch);
        [OnValueChanged("RightLowerLegTwistInOut")] public void OnRightLowerLegTwistInOutChanged() => SetMuscleEvent((int)HumanBodyMuscles.RightLowerLegTwistInOut, RightLowerLegTwistInOut);

        [OnValueChanged("RightFootUpDown")] public void OnRightFootUpDownChanged() => SetMuscleEvent((int)HumanBodyMuscles.RightFootUpDown, RightFootUpDown);
        [OnValueChanged("RightFootTwistInOut")] public void OnRightFootTwistInOutChanged() => SetMuscleEvent((int)HumanBodyMuscles.RightFootTwistInOut, RightFootTwistInOut);

        [OnValueChanged("RightToesUpDown")] public void OnRightToesUpDownChanged() => SetMuscleEvent((int)HumanBodyMuscles.RightToesUpDown, RightToesUpDown);
        #endregion
        #endregion

        #region // Inspector
        #region // Core Body
        [Foldout("Controls")]
        [Header("Body")]
        [Range(0, 1)] public float Standing;
        [Range(-1, 1)] public float CurlInOut;
        [Header("Fingers")]
        [Range(-1, 1)] public float RightFingersStretch;
        [Range(-1, 1)] public float RightFingersSpread;
        [Range(-1, 1)] public float LeftFingersStretch;
        [Range(-1, 1)] public float LeftFingersSpread;
        [Foldout("Body")]
        [Header("Spine")]
        [Range(-1, 1)] public float SpineFrontBack;
        [Range(-1, 1)] public float SpineLeftRight;
        [Range(-1, 1)] public float SpineTwistLeftRight;
        [Header("Chest")]
        [Range(-1, 1)] public float ChestFrontBack;
        [Range(-1, 1)] public float ChestLeftRight;
        [Range(-1, 1)] public float ChestTwistLeftRight;
        [Header("Upper Chest")]
        [Range(-1, 1)] public float UpperChestFrontBack;
        [Range(-1, 1)] public float UpperChestLeftRight;
        [Range(-1, 1)] public float UpperChestTwistLeftRight;
        #endregion

        #region // Head & Face
        [Foldout("Head")]
        [Header("Neck")]
        [Range(-1, 1)] public float NeckNodDownUp;
        [Range(-1, 1)] public float NeckTiltLeftRight;
        [Range(-1, 1)] public float NeckTurnLeftRight;
        [Header("Head")]
        [Range(-1, 1)] public float HeadNodDownUp;
        [Range(-1, 1)] public float HeadTiltLeftRight;
        [Range(-1, 1)] public float HeadTurnLeftRight;
        [Header("Eyes")]
        [Range(-1, 1)] public float LeftEyeDownUp;
        [Range(-1, 1)] public float LeftEyeInOut;
        [Range(-1, 1)] public float RightEyeDownUp;
        [Range(-1, 1)] public float RightEyeInOut;
        [Header("Jaw")]
        [Range(0, 1)] public float JawClose = 1;
        [Range(-1, 1)] public float JawLeftRight;
        #endregion

        #region // Arms & Hands
        [Foldout("Left Arm")]
        [Header("Shoulder")]
        [Range(-1, 1)] public float LeftShoulderDownUp;
        [Range(-1, 1)] public float LeftShoulderFrontBack = 1;
        [Header("Arm")]
        [Range(-1, 1)] public float LeftArmDownUp;
        [Range(-1, 1)] public float LeftArmFrontBack;
        [Range(-1, 1)] public float LeftArmTwistInOut;
        [Header("Forearm")]
        [Range(-1, 1)] public float LeftForearmStretch = 1;
        [Range(-1, 1)] public float LeftForearmTwistInOut;
        [Header("Hand")]
        [Range(-1, 1)] public float LeftHandDownUp;
        [Range(-1, 1)] public float LeftHandInOut;

        [Foldout("Left Fingers")]
        [Header("Thumb")]
        [Range(-1, 1)] public float LeftThumbStretch;
        [Range(-1, 1)] public float LeftThumbSpread;
        [Header("Index")]
        [Range(-1, 1)] public float LeftIndexStretch;
        [Range(-1, 1)] public float LeftIndexSpread;
        [Header("Middle")]
        [Range(-1, 1)] public float LeftMiddleStretch;
        [Range(-1, 1)] public float LeftMiddleSpread;
        [Header("Ring")]
        [Range(-1, 1)] public float LeftRingStretch;
        [Range(-1, 1)] public float LeftRingSpread;
        [Header("Little")]
        [Range(-1, 1)] public float LeftLittleStretch;
        [Range(-1, 1)] public float LeftLittleSpread;

        [Foldout("Right Arm")]
        [Header("Shoulder")]
        [Range(-1, 1)] public float RightShoulderDownUp;
        [Range(-1, 1)] public float RightShoulderFrontBack = 1;
        [Header("Arm")]
        [Range(-1, 1)] public float RightArmDownUp;
        [Range(-1, 1)] public float RightArmFrontBack;
        [Range(-1, 1)] public float RightArmTwistInOut;
        [Header("Forearm")]
        [Range(-1, 1)] public float RightForearmStretch = 1;
        [Range(-1, 1)] public float RightForearmTwistInOut;
        [Header("Hand")]
        [Range(-1, 1)] public float RightHandDownUp;
        [Range(-1, 1)] public float RightHandInOut;

        [Foldout("Right Fingers")]
        [Header("Thumb")]
        [Range(-1, 1)] public float RightThumbStretch;
        [Range(-1, 1)] public float RightThumbSpread;
        [Header("Index")]
        [Range(-1, 1)] public float RightIndexStretch;
        [Range(-1, 1)] public float RightIndexSpread;
        [Header("Middle")]
        [Range(-1, 1)] public float RightMiddleStretch;
        [Range(-1, 1)] public float RightMiddleSpread;
        [Header("Ring")]
        [Range(-1, 1)] public float RightRingStretch;
        [Range(-1, 1)] public float RightRingSpread;
        [Header("Little")]
        [Range(-1, 1)] public float RightLittleStretch;
        [Range(-1, 1)] public float RightLittleSpread;
        #endregion

        #region // Legs & Feet
        [Foldout("Left Leg")]
        [Header("Upper")]
        [Range(-1, 1)] public float LeftUpperLegFrontBack = 0.5f;
        [Range(-1, 1)] public float LeftUpperLegInOut;
        [Range(-1, 1)] public float LeftUpperLegTwistInOut;
        [Header("Lower")]
        [Range(-1, 1)] public float LeftLowerLegStretch = 1;
        [Range(-1, 1)] public float LeftLowerLegTwistInOut;
        [Header("Foot")]
        [Range(-1, 1)] public float LeftFootUpDown;
        [Range(-1, 1)] public float LeftFootTwistInOut;
        [Header("Toes")]
        [Range(-1, 1)] public float LeftToesUpDown;

        [Foldout("Right Leg")]
        [Header("Upper")]
        [Range(-1, 1)] public float RightUpperLegFrontBack = 0.5f;
        [Range(-1, 1)] public float RightUpperLegInOut;
        [Range(-1, 1)] public float RightUpperLegTwistInOut;
        [Header("Lower")]
        [Range(-1, 1)] public float RightLowerLegStretch = 1;
        [Range(-1, 1)] public float RightLowerLegTwistInOut;
        [Header("Foot")]
        [Range(-1, 1)] public float RightFootUpDown;
        [Range(-1, 1)] public float RightFootTwistInOut;
        [Header("Toes")]
        [Range(-1, 1)] public float RightToesUpDown;
        #endregion
        #endregion
    }
}
