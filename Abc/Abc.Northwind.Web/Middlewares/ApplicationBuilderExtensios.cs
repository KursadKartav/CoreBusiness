using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Northwind.Web.Middlewares
{
    public static class ApplicationBuilderExtensios //nodemodulesleri wwwroota atmak için startupta usenodemodules için açtık.
    {
        public static IApplicationBuilder UseNodeModules(this IApplicationBuilder app,string root)
        {
            var path = Path.Combine(root, "node_modules"); //rootla nodemodulesi combine et yani birleştir dedik yani root/nodemodules yazıcak.
            var provider = new PhysicalFileProvider(path); //provider static dosyaları taşımak için ara servis nesnesi.

            var options = new StaticFileOptions();
            options.RequestPath="/node_modules"; //sana bir istek gelirse 
            options.FileProvider = provider;

            app.UseStaticFiles(options);

            return app;
        }
    }
}
