using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TencentCloud.Cbs.V20170312.Models;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Cvm.V20170312.Models;
using TencentCloud.Vpc.V20170312.Models;

namespace TencentCloudAPI
{
    public class TencentCloudApiExamples
    {
        public void Run()
        {
            try
            {
                TencentCloudAPI manager = new TencentCloudAPI();

                //使用默认配置
                AllocateHostsRequest req1 = new AllocateHostsRequest();
                string strParams1 = "{}";
                req1 = AllocateHostsRequest.FromJsonString<AllocateHostsRequest>(strParams1);

                //使用 CvmClient 相关的方法
                AllocateHostsResponse resp1 = manager.CvmClient.AllocateHosts(req1).ConfigureAwait(false).GetAwaiter().GetResult();

                Console.WriteLine(AbstractModel.ToJsonString(resp1));


                //不使用默认配置
                Credential cred = new Credential
                {
                    SecretId = "",
                    SecretKey = ""
                };

                ClientProfile clientProfile = new ClientProfile();
                HttpProfile httpProfile = new HttpProfile();
                httpProfile.Endpoint = ("cbs.tencentcloudapi.com");
                clientProfile.HttpProfile = httpProfile;

                TencentCloudApiClientParam param = new TencentCloudApiClientParam();
                param.ClientProfile = clientProfile;
                param.Credential = cred;

                //设置 CbsClient 相关的配置
                manager.TencentCloudApiClientParams["CbsClient"] = param;

                DescribeDisksRequest req = new DescribeDisksRequest();
                string strParams = "{}";
                req = DescribeDisksRequest.FromJsonString<DescribeDisksRequest>(strParams);

                //使用 CbsClient 相关的方法
                DescribeDisksResponse resp = manager.CbsClient.DescribeDisks(req).ConfigureAwait(false).GetAwaiter().GetResult();

                Console.WriteLine(AbstractModel.ToJsonString(resp));
            }
            catch(Exception ex)
            {
                Console.WriteLine("ex:" + ex.ToString());
                throw ex;
            }
        }
    }
}
