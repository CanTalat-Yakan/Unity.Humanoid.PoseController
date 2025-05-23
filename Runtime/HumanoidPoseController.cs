using UnityEngine;

namespace UnityEssentials
{
    /// <summary>
    /// Controls the humanoid pose by managing muscle settings and applying them to a humanoid model.
    /// </summary>
    /// <remarks>This class provides functionality to configure and apply poses to a humanoid model by
    /// manipulating individual muscle values. It requires a <see cref="HumanoidMuscleController"/> component to
    /// function and uses <see cref="HumanoidPoseSettings"/> to define the pose configuration.</remarks>
    [RequireComponent(typeof(HumanoidMuscleController))]
    public class HumanoidPoseController : MonoBehaviour
    {
        [SerializeField] 
        private HumanoidPoseSettings _poseSettings = new();

        private HumanoidMuscleController _muscleController;

        public void Start()
        {
            if (_muscleController == null)
                _muscleController = GetComponent<HumanoidMuscleController>();

            _muscleController.Initialize();

            _poseSettings.SetMuscleEvent += (index, value) => _muscleController.SetMuscle(index, value);
        }

        [Button()]
        public void ApplyPose()
        {
            if (!_muscleController)
                return;

            #region // Core Body
            _muscleController.SetMuscle(0, _poseSettings.SpineFrontBack);
            _muscleController.SetMuscle(1, _poseSettings.SpineLeftRight);
            _muscleController.SetMuscle(2, _poseSettings.SpineTwistLeftRight);
            _muscleController.SetMuscle(3, _poseSettings.ChestFrontBack);
            _muscleController.SetMuscle(4, _poseSettings.ChestLeftRight);
            _muscleController.SetMuscle(5, _poseSettings.ChestTwistLeftRight);
            _muscleController.SetMuscle(6, _poseSettings.UpperChestFrontBack);
            _muscleController.SetMuscle(7, _poseSettings.UpperChestLeftRight);
            _muscleController.SetMuscle(8, _poseSettings.UpperChestTwistLeftRight);
            #endregion

            #region // Head & Face
            _muscleController.SetMuscle(9, _poseSettings.NeckNodDownUp);
            _muscleController.SetMuscle(10, _poseSettings.NeckTiltLeftRight);
            _muscleController.SetMuscle(11, _poseSettings.NeckTurnLeftRight);
            _muscleController.SetMuscle(12, _poseSettings.HeadNodDownUp);
            _muscleController.SetMuscle(13, _poseSettings.HeadTiltLeftRight);
            _muscleController.SetMuscle(14, _poseSettings.HeadTurnLeftRight);
            _muscleController.SetMuscle(15, _poseSettings.LeftEyeDownUp);
            _muscleController.SetMuscle(16, _poseSettings.LeftEyeInOut);
            _muscleController.SetMuscle(17, _poseSettings.RightEyeDownUp);
            _muscleController.SetMuscle(18, _poseSettings.RightEyeInOut);
            _muscleController.SetMuscle(19, _poseSettings.JawClose);
            _muscleController.SetMuscle(20, _poseSettings.JawLeftRight);
            #endregion

            #region // Arms & Hands
            // Left Arm
            _muscleController.SetMuscle(37, _poseSettings.LeftShoulderDownUp);
            _muscleController.SetMuscle(38, _poseSettings.LeftShoulderFrontBack);
            _muscleController.SetMuscle(39, _poseSettings.LeftArmDownUp);
            _muscleController.SetMuscle(40, _poseSettings.LeftArmFrontBack);
            _muscleController.SetMuscle(41, _poseSettings.LeftArmTwistInOut);
            _muscleController.SetMuscle(42, _poseSettings.LeftForearmStretch);
            _muscleController.SetMuscle(43, _poseSettings.LeftForearmTwistInOut);
            _muscleController.SetMuscle(44, _poseSettings.LeftHandDownUp);
            _muscleController.SetMuscle(45, _poseSettings.LeftHandInOut);
            #endregion

            #region // Right Arm
            _muscleController.SetMuscle(46, _poseSettings.RightShoulderDownUp);
            _muscleController.SetMuscle(47, _poseSettings.RightShoulderFrontBack);
            _muscleController.SetMuscle(48, _poseSettings.RightArmDownUp);
            _muscleController.SetMuscle(49, _poseSettings.RightArmFrontBack);
            _muscleController.SetMuscle(50, _poseSettings.RightArmTwistInOut);
            _muscleController.SetMuscle(51, _poseSettings.RightForearmStretch);
            _muscleController.SetMuscle(52, _poseSettings.RightForearmTwistInOut);
            _muscleController.SetMuscle(53, _poseSettings.RightHandDownUp);
            _muscleController.SetMuscle(54, _poseSettings.RightHandInOut);
            #endregion

            #region // Legs & Feet
            // Left Leg
            _muscleController.SetMuscle(21, _poseSettings.LeftUpperLegFrontBack);
            _muscleController.SetMuscle(22, _poseSettings.LeftUpperLegInOut);
            _muscleController.SetMuscle(23, _poseSettings.LeftUpperLegTwistInOut);
            _muscleController.SetMuscle(24, _poseSettings.LeftLowerLegStretch);
            _muscleController.SetMuscle(25, _poseSettings.LeftLowerLegTwistInOut);
            _muscleController.SetMuscle(26, _poseSettings.LeftFootUpDown);
            _muscleController.SetMuscle(27, _poseSettings.LeftFootTwistInOut);
            _muscleController.SetMuscle(28, _poseSettings.LeftToesUpDown);
            #endregion

            #region // Right Leg
            _muscleController.SetMuscle(29, _poseSettings.RightUpperLegFrontBack);
            _muscleController.SetMuscle(30, _poseSettings.RightUpperLegInOut);
            _muscleController.SetMuscle(31, _poseSettings.RightUpperLegTwistInOut);
            _muscleController.SetMuscle(32, _poseSettings.RightLowerLegStretch);
            _muscleController.SetMuscle(33, _poseSettings.RightLowerLegTwistInOut);
            _muscleController.SetMuscle(34, _poseSettings.RightFootUpDown);
            _muscleController.SetMuscle(35, _poseSettings.RightFootTwistInOut);
            _muscleController.SetMuscle(36, _poseSettings.RightToesUpDown);
            #endregion

            #region // Fingers
            // Left Hand
            _muscleController.SetMuscle(55, _poseSettings.LeftThumbStretch);
            _muscleController.SetMuscle(56, _poseSettings.LeftThumbSpread);
            _muscleController.SetMuscle(57, _poseSettings.LeftThumbStretch);
            _muscleController.SetMuscle(58, _poseSettings.LeftThumbStretch);

            _muscleController.SetMuscle(59, _poseSettings.LeftIndexStretch);
            _muscleController.SetMuscle(60, _poseSettings.LeftIndexSpread);
            _muscleController.SetMuscle(61, _poseSettings.LeftIndexStretch);
            _muscleController.SetMuscle(62, _poseSettings.LeftIndexStretch);

            _muscleController.SetMuscle(63, _poseSettings.LeftMiddleStretch);
            _muscleController.SetMuscle(64, _poseSettings.LeftMiddleSpread);
            _muscleController.SetMuscle(65, _poseSettings.LeftMiddleStretch);
            _muscleController.SetMuscle(66, _poseSettings.LeftMiddleStretch);

            _muscleController.SetMuscle(67, _poseSettings.LeftRingStretch);
            _muscleController.SetMuscle(68, _poseSettings.LeftRingSpread);
            _muscleController.SetMuscle(69, _poseSettings.LeftRingStretch);
            _muscleController.SetMuscle(70, _poseSettings.LeftRingStretch);

            _muscleController.SetMuscle(71, _poseSettings.LeftRingStretch);
            _muscleController.SetMuscle(72, _poseSettings.LeftRingSpread);
            _muscleController.SetMuscle(73, _poseSettings.LeftRingStretch);
            _muscleController.SetMuscle(74, _poseSettings.LeftRingStretch);
            #endregion

            #region // Right Hand
            _muscleController.SetMuscle(75, _poseSettings.RightThumbStretch);
            _muscleController.SetMuscle(76, _poseSettings.RightThumbSpread);
            _muscleController.SetMuscle(77, _poseSettings.RightThumbStretch);
            _muscleController.SetMuscle(78, _poseSettings.RightThumbStretch);

            _muscleController.SetMuscle(79, _poseSettings.RightIndexStretch);
            _muscleController.SetMuscle(80, _poseSettings.RightIndexSpread);
            _muscleController.SetMuscle(81, _poseSettings.RightIndexStretch);
            _muscleController.SetMuscle(82, _poseSettings.RightIndexStretch);

            _muscleController.SetMuscle(83, _poseSettings.RightMiddleStretch);
            _muscleController.SetMuscle(84, _poseSettings.RightMiddleSpread);
            _muscleController.SetMuscle(85, _poseSettings.RightMiddleStretch);
            _muscleController.SetMuscle(86, _poseSettings.RightMiddleStretch);

            _muscleController.SetMuscle(87, _poseSettings.RightRingStretch);
            _muscleController.SetMuscle(88, _poseSettings.RightRingSpread);
            _muscleController.SetMuscle(89, _poseSettings.RightRingStretch);
            _muscleController.SetMuscle(90, _poseSettings.RightRingStretch);

            _muscleController.SetMuscle(91, _poseSettings.RightRingStretch);
            _muscleController.SetMuscle(92, _poseSettings.RightRingSpread);
            _muscleController.SetMuscle(93, _poseSettings.RightRingStretch);
            _muscleController.SetMuscle(94, _poseSettings.RightRingStretch);
            #endregion
        }

        [Button()]
        public void ResetPose()
        {
            _poseSettings = new();
            _muscleController.ResetAllMuscles();
        }
    }
}