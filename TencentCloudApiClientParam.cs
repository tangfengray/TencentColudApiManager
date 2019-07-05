using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TencentCloudAPI
{
    public class TencentCloudApiClientParam
    {
        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Common.Credential Credential { get; set; } = null;

        /// <summary>
        /// 
        /// </summary>
        public string Region { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Common.Profile.ClientProfile ClientProfile { get; set; } = null;
    }
}
