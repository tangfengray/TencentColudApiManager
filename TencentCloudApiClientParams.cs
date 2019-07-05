using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TencentCloudAPI
{
    public class TencentCloudApiClientParams
    {
        private static Dictionary<string, TencentCloudApiClientParam> DicClientParams = null;

        public TencentCloudApiClientParams()
        {
            DicClientParams = new Dictionary<string, TencentCloudApiClientParam>(StringComparer.OrdinalIgnoreCase);
        }

        public TencentCloudApiClientParam this[string index]
        {
            get
            {
                if (!DicClientParams.Keys.Contains(index, StringComparer.OrdinalIgnoreCase))
                    return null;
                return DicClientParams[index];
            }
            set
            {
                DicClientParams[index] = value;
            }
        }
    }
}
