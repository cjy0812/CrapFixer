using System.Threading.Tasks;
using System.Globalization;

namespace CrapFixer
{
    public abstract class FeatureBase
    {
        public abstract string ID();
        public abstract string Info();
        public abstract string GetFeatureDetails();
        public abstract Task<bool> CheckFeature();  // async
        public abstract Task<bool> DoFeature();    // async
        public abstract bool UndoFeature();

        /// <summary>
        /// Load localized string for this feature. Tries keys like "Ads.FileExplorerAds.ID" in `Properties.Resources`.
        /// Falls back to provided fallback (formatted with args) or to "Class.Key".
        /// </summary>
        protected string L(string key, string fallback = null, params object[] args)
        {
            var className = GetType().Name;
            var categories = new[] { "Ads", "AI", "Edge", "Gaming", "Issues", "Privacy", "System", "UI" };

            foreach (var cat in categories)
            {
                var composite = $"{cat}.{className}.{key}";
                var v = Properties.Resources.ResourceManager.GetString(composite, Properties.Resources.Culture);
                if (!string.IsNullOrEmpty(v))
                    return args != null && args.Length > 0 ? string.Format(CultureInfo.CurrentCulture, v, args) : v;
            }

            var alt = $"{className}.{key}";
            var v2 = Properties.Resources.ResourceManager.GetString(alt, Properties.Resources.Culture);
            if (!string.IsNullOrEmpty(v2))
                return args != null && args.Length > 0 ? string.Format(CultureInfo.CurrentCulture, v2, args) : v2;

            if (!string.IsNullOrEmpty(fallback))
                return args != null && args.Length > 0 ? string.Format(CultureInfo.CurrentCulture, fallback, args) : fallback;

n            return $"{className}.{key}";
        }
    }

}
