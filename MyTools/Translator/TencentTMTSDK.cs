using System;
using System.Threading.Tasks;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Tmt.V20180321;
using TencentCloud.Tmt.V20180321.Models;

namespace MyTools.Translator
{
    public class TencentTMTSDK
    {
        public TencentTMTSDK()
        {
            httpProfile.Endpoint = ("tmt.tencentcloudapi.com");
            clientProfile.HttpProfile = httpProfile;
        }
        public TencentTMTSDK(string SecretId, string SecretKey)
        {
            cred.SecretId = SecretId;
            cred.SecretKey = SecretKey;
        }
        public TencentTMTSDK(string SecretId, string SecretKey, string Source, string Target)
        {
            cred.SecretId = SecretId;
            cred.SecretKey = SecretKey;
            this.Source = Source;
            this.Target = Target;
        }
        private Credential cred = new Credential
        {
            SecretId = "AKIDsqIahdQ0PdprhQ9EJuY2NXVISVN99APU",
            SecretKey = "HyMnUs5DvSYTDTYfjEh9RccljW9bZRYY"
        };
        private ClientProfile clientProfile = new ClientProfile();
        private HttpProfile httpProfile = new HttpProfile();
        private TmtClient client;
        private TextTranslateRequest req = new TextTranslateRequest();

        public string SourceText { get;set;  }
        public string Source = "en";
        public string Target = "zh";
        public string GetResult()
        {
            client = new TmtClient(cred, "ap-guangzhou-open", clientProfile);
            string strParams = "{\"SourceText\":\"" + SourceText + "\",\"Source\":\"" + Source + "\",\"Target\":\"" + Target + "\",\"ProjectId\":0}";
            req = AbstractModel.FromJsonString<TextTranslateRequest>(strParams);
            TextTranslateResponse resp = client.TextTranslate(req).Result;
            return AbstractModel.ToJsonString(resp);
        }
    }
}
