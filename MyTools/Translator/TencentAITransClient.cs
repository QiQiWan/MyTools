using System;
using System.Collections.Generic;

namespace MyTools.Translator
{
    public class TencentAITransClient
    {
        public TencentAITransClient()
        {
            Init();
        }
        private void Init()
        {
            
            Param["app_id"] = "2112027344";
            Param["time_stamp"] = "1493449657";
            Param["nonce_str"] = "20e3408a79";
            Param["key1"] = "小程序翻译能力";
            Param["key2"] = "工具软件";
            Param["sign"] = "";
        }
        private string GetReqSign(Dictionary<string, string> Param, string AppKey)
        {
            string paramStr = "";
            foreach(var item in Param)
            {
                paramStr += item.Key + "=" + new Uri(item.Value).ToString() + "&";
            }
            paramStr += "app_key=" + AppKey;
            

            return "";
        }
        //接口调用的参数
        private Dictionary<string, string> Param = new Dictionary<string, string>();
        private string AppKey = "a95eceb1ac8c24ee28b70f7dbba912bf";
        




    }
}
