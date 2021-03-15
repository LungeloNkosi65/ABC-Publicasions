using ABC_Publicasions.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ABC_Publicasions.Services
{
    public class JsonDeserialiserService
    {
        public static Root_ root_;
        public JsonDeserialiserService()
        {
            root_ = new Root_();
        }

        public Root_ DeserialiseJson()
        {
            string path = @"C:\Users\Lungelo Nkosi\Documents\Lungelo\Assessment_graph\the-adventures-of-sherlock-holmes-sample[1].json";

            using (StreamReader file = File.OpenText(path))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject jObject = (JObject)JToken.ReadFrom(reader);
                var children = jObject.Properties();
                foreach (var item in children)
                {
                    var generic = item.Value.ToObject<GenericMap>();
                    root_.DictContent.Add(item.Name, generic);

                }
            }
                return root_;
        }


        public GenericMap GetDataFromDictionery(Dictionary<string,GenericMap> keyValues, string key)
        {
            //var x=  keyValues.Where(cx=>cx.Key==key).Select(ax=>ax.Value);
            var test = keyValues.TryGetValue(key, out GenericMap genericMap);
            if (test)
            {
                return genericMap;
            }

            //foreach (var item in keyValues)
            //{
            //    if (item.Key == key)
            //    {
            //        return item.Value;
            //    }
            //}
            return new GenericMap();
        }


        

    }
}