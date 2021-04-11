using System.ComponentModel;

namespace WordPressLicenseManagerNETClient.Consts
{
    /// <summary>
    /// License actions. Used by <see cref="ILicenseManager.PerformAction(Action, Models.License)"></see> or <see cref="ILicenseManager.PerformActionAsync(Action, Models.License)"></see>
    /// </summary>
    public enum Action
    {
        /// <summary>
        /// Default value
        /// </summary>
        [Description("slm_undefined")]
        Unknown,
        /// <summary>
        /// Create a new license
        /// </summary>
        [Description("slm_create_new")]
        Create,
        /// <summary>
        /// Activate an existing license
        /// </summary>
        [Description("slm_activate")]
        Activate,
        /// <summary>
        /// Deactivate an existing license
        /// </summary>
        [Description("slm_deactivate")]
        Deactivate,
        /// <summary>
        /// Check an existing license
        /// </summary>
        [Description("slm_check")]
        Check,
        /// <summary>
        /// get an existing license by product reference
        /// </summary>
        [Description("slm_get")]
        Get,
        /// <summary>
        /// update existing new license
        /// </summary>
        [Description("slm_update")]
        Update,
    }
}
