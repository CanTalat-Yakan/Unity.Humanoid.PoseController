using UnityEngine;

namespace UnityEssentials
{
    public class HumanoidMuscleController : MonoBehaviour
    {
        [SerializeField] private Avatar _avatar;

        private HumanPoseHandler _poseHandler;
        private HumanPose _humanPose;

        private bool _isInitialized;

        public void Start() =>
            Initialize();

        public void Initialize()
        {
            if (_avatar == null || !_avatar.isHuman)
            {
                Debug.LogError("Missing or invalid Humanoid Avatar!");
                return;
            }

            _poseHandler = new HumanPoseHandler(_avatar, transform);
            _humanPose = new HumanPose();
            _isInitialized = true;
        }

        public void SetMuscle(HumanBodyMuscles muscle, float value)
        {
            if (!_isInitialized) Initialize();
            if (!_isInitialized) return;

            _poseHandler.GetHumanPose(ref _humanPose);
            _humanPose.muscles[(int)muscle] = Mathf.Clamp(value, -1, 1);
            _poseHandler.SetHumanPose(ref _humanPose);
        }

        public void SetMuscle(int muscleIndex, float value)
        {
            if (!_isInitialized) Initialize();
            if (!_isInitialized) return;

            if (muscleIndex < 0 || muscleIndex >= HumanTrait.MuscleCount)
            {
                Debug.LogError($"Invalid muscle index: {muscleIndex} (Must be 0-{HumanTrait.MuscleCount - 1})");
                return;
            }

            _poseHandler.GetHumanPose(ref _humanPose);
            _humanPose.muscles[muscleIndex] = Mathf.Clamp(value, -1, 1);
            _poseHandler.SetHumanPose(ref _humanPose);
        }

        public void SetMuscle(string muscleName, float value)
        {
            if (!_isInitialized) Initialize();
            if (!_isInitialized) return;

            for (int i = 0; i < HumanTrait.MuscleCount; i++)
            {
                if (HumanTrait.MuscleName[i] == muscleName)
                {
                    SetMuscle(i, value);
                    return;
                }
            }
            Debug.LogError($"Muscle not found: {muscleName}");
        }

        public void ResetAllMuscles()
        {
            if (!_isInitialized) Initialize();
            if (!_isInitialized) return;

            _poseHandler.GetHumanPose(ref _humanPose);
            for (int i = 0; i < _humanPose.muscles.Length; i++)
                _humanPose.muscles[i] = 0;

            _poseHandler.SetHumanPose(ref _humanPose);
        }

        public void PrintAllMuscles()
        {
            for (int i = 0; i < HumanTrait.MuscleCount; i++)
                Debug.Log($"{i}: {HumanTrait.MuscleName[i]}");
        }
    }

    public enum HumanBodyMuscles
    {
        SpineFrontBack,
        SpineLeftRight,
        SpineTwistLeftRight,
        ChestFrontBack,
        ChestLeftRight,
        ChestTwistLeftRight,
        UpperChestFrontBack,
        UpperChestLeftRight,
        UpperChestTwistLeftRight,
        NeckNodDownUp,
        NeckTiltLeftRight,
        NeckTurnLeftRight,
        HeadNodDownUp,
        HeadTiltLeftRight,
        HeadTurnLeftRight,
        LeftEyeDownUp,
        LeftEyeInOut,
        RightEyeDownUp,
        RightEyeInOut,
        JawClose,
        JawLeftRight,
        LeftUpperLegFrontBack,
        LeftUpperLegInOut,
        LeftUpperLegTwistInOut,
        LeftLowerLegStretch,
        LeftLowerLegTwistInOut,
        LeftFootUpDown,
        LeftFootTwistInOut,
        LeftToesUpDown,
        RightUpperLegFrontBack,
        RightUpperLegInOut,
        RightUpperLegTwistInOut,
        RightLowerLegStretch,
        RightLowerLegTwistInOut,
        RightFootUpDown,
        RightFootTwistInOut,
        RightToesUpDown,
        LeftShoulderDownUp,
        LeftShoulderFrontBack,
        LeftArmDownUp,
        LeftArmFrontBack,
        LeftArmTwistInOut,
        LeftForearmStretch,
        LeftForearmTwistInOut,
        LeftHandDownUp,
        LeftHandInOut,
        RightShoulderDownUp,
        RightShoulderFrontBack,
        RightArmDownUp,
        RightArmFrontBack,
        RightArmTwistInOut,
        RightForearmStretch,
        RightForearmTwistInOut,
        RightHandDownUp,
        RightHandInOut,
        LeftThumb1Stretched,
        LeftThumbSpread,
        LeftThumb2Stretched,
        LeftThumb3Stretched,
        LeftIndex1Stretched,
        LeftIndexSpread,
        LeftIndex2Stretched,
        LeftIndex3Stretched,
        LeftMiddle1Stretched,
        LeftMiddleSpread,
        LeftMiddle2Stretched,
        LeftMiddle3Stretched,
        LeftRing1Stretched,
        LeftRingSpread,
        LeftRing2Stretched,
        LeftRing3Stretched,
        LeftLittle1Stretched,
        LeftLittleSpread,
        LeftLittle2Stretched,
        LeftLittle3Stretched,
        RightThumb1Stretched,
        RightThumbSpread,
        RightThumb2Stretched,
        RightThumb3Stretched,
        RightIndex1Stretched,
        RightIndexSpread,
        RightIndex2Stretched,
        RightIndex3Stretched,
        RightMiddle1Stretched,
        RightMiddleSpread,
        RightMiddle2Stretched,
        RightMiddle3Stretched,
        RightRing1Stretched,
        RightRingSpread,
        RightRing2Stretched,
        RightRing3Stretched,
        RightLittle1Stretched,
        RightLittleSpread,
        RightLittle2Stretched,
        RightLittle3Stretched
    }
}