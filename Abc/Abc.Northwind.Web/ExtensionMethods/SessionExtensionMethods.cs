using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Northwind.Web.ExtensionMethods
{
    public static class SessionExtensionMethods //Extension methodları barındırabilmesi için static olmalı.
    {
        public static void SetObject(this ISession session,string key ,object value)
        {
            string objectString = JsonConvert.SerializeObject(value); //stringleri objeye dönüştürmem gerekiyor sessionda kullanmak için 
            session.SetString(key, objectString); //O yüzden bu yöntemleri uyguluyorum.
        }
        public static T GetObject<T>(this ISession session,string key) where T : class
        {
            string objectString = session.GetString(key);
            if (string.IsNullOrEmpty(objectString))
            {
                return null;
            }

            T value = JsonConvert.DeserializeObject<T>(objectString);
            return value;
        }
    }
}
