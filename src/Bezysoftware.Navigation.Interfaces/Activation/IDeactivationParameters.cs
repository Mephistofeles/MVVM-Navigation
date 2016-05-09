using System;

namespace Bezysoftware.Navigation.Activation
{
    public interface IDeactivationParameters
    {
        /// <summary>
        /// Target ViewModel which will be activated if current deactivation takes place.
        /// </summary>
        Type TargetViewModelType { get; }

        /// <summary>
        /// Data which will be passed to target ViewModel if current deactivation takes place. This data can be overriden.
        /// </summary>
        object DeactivationData { get; set; }
    }
}