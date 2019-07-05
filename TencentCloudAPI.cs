using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TencentCloudAPI
{
    /// <summary>
    ///  简单的腾讯云SDK封装操作类 
    ///  
    ///  2019年7月5日13:26:24
    /// </summary>
    public class TencentCloudAPI
    {
        private static TencentCloudApiClientParam DefaultTencentCloudApiClientParam { get; set; } = null;

        public TencentCloudApiClientParams TencentCloudApiClientParams { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloudAPI()
        {
            TencentCloudApiClientParams = new TencentCloudApiClientParams();

            DefaultTencentCloudApiClientParam = new TencentCloudApiClientParam();

            DefaultTencentCloudApiClientParam.Credential = new TencentCloud.Common.Credential
            {
                SecretId = @"",//默认值
                SecretKey = @""//默认值
            };

            DefaultTencentCloudApiClientParam.Region = @"";//默认值
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Aai.V20180522.AaiClient AaiClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["AaiClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Aai.V20180522.AaiClient result = TencentCloudApiClientParams["AaiClient"] == null ?
                    new TencentCloud.Aai.V20180522.AaiClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Aai.V20180522.AaiClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.As.V20180419.AsClient AsClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["AsClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.As.V20180419.AsClient result = TencentCloudApiClientParams["AsClient"] == null ?
                    new TencentCloud.As.V20180419.AsClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.As.V20180419.AsClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Batch.V20170312.BatchClient BatchClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["BatchClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Batch.V20170312.BatchClient result = TencentCloudApiClientParams["BatchClient"] == null ?
                    new TencentCloud.Batch.V20170312.BatchClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Batch.V20170312.BatchClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Billing.V20180709.BillingClient BillingClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["BillingClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Billing.V20180709.BillingClient result = TencentCloudApiClientParams["BillingClient"] == null ?
                    new TencentCloud.Billing.V20180709.BillingClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Billing.V20180709.BillingClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Bizlive.V20190313.BizliveClient BizliveClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["BizliveClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Bizlive.V20190313.BizliveClient result = TencentCloudApiClientParams["BizliveClient"] == null ?
                    new TencentCloud.Bizlive.V20190313.BizliveClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Bizlive.V20190313.BizliveClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Bm.V20180423.BmClient BmClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["BmClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Bm.V20180423.BmClient result = TencentCloudApiClientParams["BmClient"] == null ?
                    new TencentCloud.Bm.V20180423.BmClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Bm.V20180423.BmClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Bmeip.V20180625.BmeipClient BmeipClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["BmeipClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Bmeip.V20180625.BmeipClient result = TencentCloudApiClientParams["BmeipClient"] == null ?
                    new TencentCloud.Bmeip.V20180625.BmeipClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Bmeip.V20180625.BmeipClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Bmlb.V20180625.BmlbClient BmlbClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["BmlbClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Bmlb.V20180625.BmlbClient result = TencentCloudApiClientParams["BmlbClient"] == null ?
                    new TencentCloud.Bmlb.V20180625.BmlbClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Bmlb.V20180625.BmlbClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Bmvpc.V20180625.BmvpcClient BmvpcClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["BmvpcClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Bmvpc.V20180625.BmvpcClient result = TencentCloudApiClientParams["BmvpcClient"] == null ?
                    new TencentCloud.Bmvpc.V20180625.BmvpcClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Bmvpc.V20180625.BmvpcClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Cam.V20190116.CamClient CamClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["CamClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Cam.V20190116.CamClient result = TencentCloudApiClientParams["CamClient"] == null ?
                    new TencentCloud.Cam.V20190116.CamClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Cam.V20190116.CamClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Cbs.V20170312.CbsClient CbsClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["CbsClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Cbs.V20170312.CbsClient result = TencentCloudApiClientParams["CbsClient"] == null ?
                    new TencentCloud.Cbs.V20170312.CbsClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Cbs.V20170312.CbsClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Cdb.V20170320.CdbClient CdbClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["CdbClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Cdb.V20170320.CdbClient result = TencentCloudApiClientParams["CdbClient"] == null ?
                    new TencentCloud.Cdb.V20170320.CdbClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Cdb.V20170320.CdbClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Cdn.V20180606.CdnClient CdnClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["CdnClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Cdn.V20180606.CdnClient result = TencentCloudApiClientParams["CdnClient"] == null ?
                    new TencentCloud.Cdn.V20180606.CdnClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Cdn.V20180606.CdnClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Cds.V20180420.CdsClient CdsClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["CdsClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Cds.V20180420.CdsClient result = TencentCloudApiClientParams["CdsClient"] == null ?
                    new TencentCloud.Cds.V20180420.CdsClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Cds.V20180420.CdsClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Cim.V20190318.CimClient CimClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["CimClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Cim.V20190318.CimClient result = TencentCloudApiClientParams["CimClient"] == null ?
                    new TencentCloud.Cim.V20190318.CimClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Cim.V20190318.CimClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Cis.V20180408.CisClient CisClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["CisClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Cis.V20180408.CisClient result = TencentCloudApiClientParams["CisClient"] == null ?
                    new TencentCloud.Cis.V20180408.CisClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Cis.V20180408.CisClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Clb.V20180317.ClbClient ClbClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["ClbClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Clb.V20180317.ClbClient result = TencentCloudApiClientParams["ClbClient"] == null ?
                    new TencentCloud.Clb.V20180317.ClbClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Clb.V20180317.ClbClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Cloudaudit.V20190319.CloudauditClient CloudauditClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["CloudauditClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Cloudaudit.V20190319.CloudauditClient result = TencentCloudApiClientParams["CloudauditClient"] == null ?
                    new TencentCloud.Cloudaudit.V20190319.CloudauditClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Cloudaudit.V20190319.CloudauditClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Cms.V20190321.CmsClient CmsClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["CmsClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Cms.V20190321.CmsClient result = TencentCloudApiClientParams["CmsClient"] == null ?
                    new TencentCloud.Cms.V20190321.CmsClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Cms.V20190321.CmsClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Cr.V20180321.CrClient CrClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["CrClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Cr.V20180321.CrClient result = TencentCloudApiClientParams["CrClient"] == null ?
                    new TencentCloud.Cr.V20180321.CrClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Cr.V20180321.CrClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Cvm.V20170312.CvmClient CvmClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["CvmClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Cvm.V20170312.CvmClient result = TencentCloudApiClientParams["CvmClient"] == null ?
                    new TencentCloud.Cvm.V20170312.CvmClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Cvm.V20170312.CvmClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Cws.V20180312.CwsClient CwsClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["CwsClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Cws.V20180312.CwsClient result = TencentCloudApiClientParams["CwsClient"] == null ?
                    new TencentCloud.Cws.V20180312.CwsClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Cws.V20180312.CwsClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Dc.V20180410.DcClient DcClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["DcClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Dc.V20180410.DcClient result = TencentCloudApiClientParams["DcClient"] == null ?
                    new TencentCloud.Dc.V20180410.DcClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Dc.V20180410.DcClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Dcdb.V20180411.DcdbClient DcdbClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["DcdbClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Dcdb.V20180411.DcdbClient result = TencentCloudApiClientParams["DcdbClient"] == null ?
                    new TencentCloud.Dcdb.V20180411.DcdbClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Dcdb.V20180411.DcdbClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Drm.V20181115.DrmClient DrmClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["DrmClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Drm.V20181115.DrmClient result = TencentCloudApiClientParams["DrmClient"] == null ?
                    new TencentCloud.Drm.V20181115.DrmClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Drm.V20181115.DrmClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Ds.V20180523.DsClient DsClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["DsClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Ds.V20180523.DsClient result = TencentCloudApiClientParams["DsClient"] == null ?
                    new TencentCloud.Ds.V20180523.DsClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Ds.V20180523.DsClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Dts.V20180330.DtsClient DtsClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["DtsClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Dts.V20180330.DtsClient result = TencentCloudApiClientParams["DtsClient"] == null ?
                    new TencentCloud.Dts.V20180330.DtsClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Dts.V20180330.DtsClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Ecc.V20181213.EccClient EccClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["EccClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Ecc.V20181213.EccClient result = TencentCloudApiClientParams["EccClient"] == null ?
                    new TencentCloud.Ecc.V20181213.EccClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Ecc.V20181213.EccClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Emr.V20190103.EmrClient EmrClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["EmrClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Emr.V20190103.EmrClient result = TencentCloudApiClientParams["EmrClient"] == null ?
                    new TencentCloud.Emr.V20190103.EmrClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Emr.V20190103.EmrClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Es.V20180416.EsClient EsClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["EsClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Es.V20180416.EsClient result = TencentCloudApiClientParams["EsClient"] == null ?
                    new TencentCloud.Es.V20180416.EsClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Es.V20180416.EsClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Facefusion.V20181201.FacefusionClient FacefusionClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["FacefusionClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Facefusion.V20181201.FacefusionClient result = TencentCloudApiClientParams["FacefusionClient"] == null ?
                    new TencentCloud.Facefusion.V20181201.FacefusionClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Facefusion.V20181201.FacefusionClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Faceid.V20180301.FaceidClient FaceidClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["FaceidClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Faceid.V20180301.FaceidClient result = TencentCloudApiClientParams["FaceidClient"] == null ?
                    new TencentCloud.Faceid.V20180301.FaceidClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Faceid.V20180301.FaceidClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Habo.V20181203.HaboClient HaboClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["HaboClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Habo.V20181203.HaboClient result = TencentCloudApiClientParams["HaboClient"] == null ?
                    new TencentCloud.Habo.V20181203.HaboClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Habo.V20181203.HaboClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Hcm.V20181106.HcmClient HcmClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["HcmClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Hcm.V20181106.HcmClient result = TencentCloudApiClientParams["HcmClient"] == null ?
                    new TencentCloud.Hcm.V20181106.HcmClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Hcm.V20181106.HcmClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Iai.V20180301.IaiClient IaiClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["IaiClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Iai.V20180301.IaiClient result = TencentCloudApiClientParams["IaiClient"] == null ?
                    new TencentCloud.Iai.V20180301.IaiClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Iai.V20180301.IaiClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Ic.V20190307.IcClient IcClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["IcClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Ic.V20190307.IcClient result = TencentCloudApiClientParams["IcClient"] == null ?
                    new TencentCloud.Ic.V20190307.IcClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Ic.V20190307.IcClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Iot.V20180123.IotClient IotClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["IotClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Iot.V20180123.IotClient result = TencentCloudApiClientParams["IotClient"] == null ?
                    new TencentCloud.Iot.V20180123.IotClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Iot.V20180123.IotClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Iotcloud.V20180614.IotcloudClient IotcloudClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["IotcloudClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Iotcloud.V20180614.IotcloudClient result = TencentCloudApiClientParams["IotcloudClient"] == null ?
                    new TencentCloud.Iotcloud.V20180614.IotcloudClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Iotcloud.V20180614.IotcloudClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Iotexplorer.V20190423.IotexplorerClient IotexplorerClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["IotexplorerClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Iotexplorer.V20190423.IotexplorerClient result = TencentCloudApiClientParams["IotexplorerClient"] == null ?
                    new TencentCloud.Iotexplorer.V20190423.IotexplorerClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Iotexplorer.V20190423.IotexplorerClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Kms.V20190118.KmsClient KmsClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["KmsClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Kms.V20190118.KmsClient result = TencentCloudApiClientParams["KmsClient"] == null ?
                    new TencentCloud.Kms.V20190118.KmsClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Kms.V20190118.KmsClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Live.V20180801.LiveClient LiveClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["LiveClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Live.V20180801.LiveClient result = TencentCloudApiClientParams["LiveClient"] == null ?
                    new TencentCloud.Live.V20180801.LiveClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Live.V20180801.LiveClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Mariadb.V20170312.MariadbClient MariadbClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["MariadbClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Mariadb.V20170312.MariadbClient result = TencentCloudApiClientParams["MariadbClient"] == null ?
                    new TencentCloud.Mariadb.V20170312.MariadbClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Mariadb.V20170312.MariadbClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Mongodb.V20180408.MongodbClient MongodbClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["MongodbClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Mongodb.V20180408.MongodbClient result = TencentCloudApiClientParams["MongodbClient"] == null ?
                    new TencentCloud.Mongodb.V20180408.MongodbClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Mongodb.V20180408.MongodbClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Monitor.V20180724.MonitorClient MonitorClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["MonitorClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Monitor.V20180724.MonitorClient result = TencentCloudApiClientParams["MonitorClient"] == null ?
                    new TencentCloud.Monitor.V20180724.MonitorClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Monitor.V20180724.MonitorClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Ms.V20180408.MsClient MsClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["MsClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Ms.V20180408.MsClient result = TencentCloudApiClientParams["MsClient"] == null ?
                    new TencentCloud.Ms.V20180408.MsClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Ms.V20180408.MsClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Msp.V20180319.MspClient MspClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["MspClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Msp.V20180319.MspClient result = TencentCloudApiClientParams["MspClient"] == null ?
                    new TencentCloud.Msp.V20180319.MspClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Msp.V20180319.MspClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Ocr.V20181119.OcrClient OcrClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["OcrClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Ocr.V20181119.OcrClient result = TencentCloudApiClientParams["OcrClient"] == null ?
                    new TencentCloud.Ocr.V20181119.OcrClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Ocr.V20181119.OcrClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Partners.V20180321.PartnersClient PartnersClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["PartnersClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Partners.V20180321.PartnersClient result = TencentCloudApiClientParams["PartnersClient"] == null ?
                    new TencentCloud.Partners.V20180321.PartnersClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Partners.V20180321.PartnersClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Postgres.V20170312.PostgresClient PostgresClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["PostgresClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Postgres.V20170312.PostgresClient result = TencentCloudApiClientParams["PostgresClient"] == null ?
                    new TencentCloud.Postgres.V20170312.PostgresClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Postgres.V20170312.PostgresClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Redis.V20180412.RedisClient RedisClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["RedisClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Redis.V20180412.RedisClient result = TencentCloudApiClientParams["RedisClient"] == null ?
                    new TencentCloud.Redis.V20180412.RedisClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Redis.V20180412.RedisClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Scf.V20180416.ScfClient ScfClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["ScfClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Scf.V20180416.ScfClient result = TencentCloudApiClientParams["ScfClient"] == null ?
                    new TencentCloud.Scf.V20180416.ScfClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Scf.V20180416.ScfClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Soe.V20180724.SoeClient SoeClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["SoeClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Soe.V20180724.SoeClient result = TencentCloudApiClientParams["SoeClient"] == null ?
                    new TencentCloud.Soe.V20180724.SoeClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Soe.V20180724.SoeClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Sqlserver.V20180328.SqlserverClient SqlserverClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["SqlserverClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Sqlserver.V20180328.SqlserverClient result = TencentCloudApiClientParams["SqlserverClient"] == null ?
                    new TencentCloud.Sqlserver.V20180328.SqlserverClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Sqlserver.V20180328.SqlserverClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Sts.V20180813.StsClient StsClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["StsClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Sts.V20180813.StsClient result = TencentCloudApiClientParams["StsClient"] == null ?
                    new TencentCloud.Sts.V20180813.StsClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Sts.V20180813.StsClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Tag.V20180813.TagClient TagClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["TagClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Tag.V20180813.TagClient result = TencentCloudApiClientParams["TagClient"] == null ?
                    new TencentCloud.Tag.V20180813.TagClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Tag.V20180813.TagClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Tav.V20190118.TavClient TavClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["TavClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Tav.V20190118.TavClient result = TencentCloudApiClientParams["TavClient"] == null ?
                    new TencentCloud.Tav.V20190118.TavClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Tav.V20190118.TavClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Tbaas.V20180416.TbaasClient TbaasClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["TbaasClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Tbaas.V20180416.TbaasClient result = TencentCloudApiClientParams["TbaasClient"] == null ?
                    new TencentCloud.Tbaas.V20180416.TbaasClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Tbaas.V20180416.TbaasClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Tbm.V20180129.TbmClient TbmClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["TbmClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Tbm.V20180129.TbmClient result = TencentCloudApiClientParams["TbmClient"] == null ?
                    new TencentCloud.Tbm.V20180129.TbmClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Tbm.V20180129.TbmClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Tbp.V20190311.TbpClient TbpClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["TbpClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Tbp.V20190311.TbpClient result = TencentCloudApiClientParams["TbpClient"] == null ?
                    new TencentCloud.Tbp.V20190311.TbpClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Tbp.V20190311.TbpClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Tcb.V20180608.TcbClient TcbClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["TcbClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Tcb.V20180608.TcbClient result = TencentCloudApiClientParams["TcbClient"] == null ?
                    new TencentCloud.Tcb.V20180608.TcbClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Tcb.V20180608.TcbClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Tia.V20180226.TiaClient TiaClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["TiaClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Tia.V20180226.TiaClient result = TencentCloudApiClientParams["TiaClient"] == null ?
                    new TencentCloud.Tia.V20180226.TiaClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Tia.V20180226.TiaClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Ticm.V20181127.TicmClient TicmClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["TicmClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Ticm.V20181127.TicmClient result = TencentCloudApiClientParams["TicmClient"] == null ?
                    new TencentCloud.Ticm.V20181127.TicmClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Ticm.V20181127.TicmClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Tics.V20181115.TicsClient TicsClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["TicsClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Tics.V20181115.TicsClient result = TencentCloudApiClientParams["TicsClient"] == null ?
                    new TencentCloud.Tics.V20181115.TicsClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Tics.V20181115.TicsClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Tke.V20180525.TkeClient TkeClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["TkeClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Tke.V20180525.TkeClient result = TencentCloudApiClientParams["TkeClient"] == null ?
                    new TencentCloud.Tke.V20180525.TkeClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Tke.V20180525.TkeClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Tmt.V20180321.TmtClient TmtClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["TmtClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Tmt.V20180321.TmtClient result = TencentCloudApiClientParams["TmtClient"] == null ?
                    new TencentCloud.Tmt.V20180321.TmtClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Tmt.V20180321.TmtClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Vod.V20180717.VodClient VodClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["VodClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Vod.V20180717.VodClient result = TencentCloudApiClientParams["VodClient"] == null ?
                    new TencentCloud.Vod.V20180717.VodClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Vod.V20180717.VodClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Vpc.V20170312.VpcClient VpcClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["VpcClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Vpc.V20170312.VpcClient result = TencentCloudApiClientParams["VpcClient"] == null ?
                    new TencentCloud.Vpc.V20170312.VpcClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Vpc.V20170312.VpcClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Youmall.V20180228.YoumallClient YoumallClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["YoumallClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Youmall.V20180228.YoumallClient result = TencentCloudApiClientParams["YoumallClient"] == null ?
                    new TencentCloud.Youmall.V20180228.YoumallClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Youmall.V20180228.YoumallClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Yunjing.V20180228.YunjingClient YunjingClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["YunjingClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Yunjing.V20180228.YunjingClient result = TencentCloudApiClientParams["YunjingClient"] == null ?
                    new TencentCloud.Yunjing.V20180228.YunjingClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Yunjing.V20180228.YunjingClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TencentCloud.Yunsou.V20180504.YunsouClient YunsouClient
        {
            get
            {
                TencentCloudApiClientParam ClientParam = TencentCloudApiClientParams["YunsouClient"] ?? DefaultTencentCloudApiClientParam;

                TencentCloud.Yunsou.V20180504.YunsouClient result = TencentCloudApiClientParams["YunsouClient"] == null ?
                    new TencentCloud.Yunsou.V20180504.YunsouClient(ClientParam.Credential, ClientParam.Region) :
                    new TencentCloud.Yunsou.V20180504.YunsouClient(ClientParam.Credential, ClientParam.Region, ClientParam.ClientProfile);

                return result;
            }
        }



    }

}
