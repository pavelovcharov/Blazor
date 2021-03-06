using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlazorDemo.Configuration {
    public class DemoPageBase : DemoPageSection {
        public string Url { get; set; }
        public string SeoTitle { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }

        public string OG_Title { get; set; }
        public string OG_Image { get; set; }
        public string OG_Description { get; set; }
        public string OG_Url { get; set; }
        public string OG_Type { get; set; }
    }

    public class DemoRootPage : DemoPageBase {
        public DemoPage[] Pages { get; set; }
        public bool IsServerSideOnly { get; set; }
        public string AnalyticsId { get; set; }
        public override string Uri => DemoConfiguration.GetRootDemoPageUrl(this);
    }

    public class DemoPage : DemoPageBase {
        public DemoPageSection[] PageSections { get; set; }
        [JsonIgnore]
        public override string Uri => Url;
    }
}
