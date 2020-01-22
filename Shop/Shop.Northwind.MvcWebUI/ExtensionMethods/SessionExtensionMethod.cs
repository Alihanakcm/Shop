using System;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Shop.Northwind.MvcWebUI.ExtensionMethods
{
    public static class SessionExtensionMethod
    {
        public static void SetObjects(this ISession session, string key, object value)
        {
            var objectString = JsonConvert.SerializeObject(value);
            session.SetString(key, objectString);
        }

        public static T GetObjects<T>(this ISession session, string key) where T : class
        {
            var objectString = session.GetString(key);
            if (String.IsNullOrEmpty(objectString))
            {
                return null;
            }

            T value = JsonConvert.DeserializeObject<T>(objectString);
            return value;
        }
    }
}
