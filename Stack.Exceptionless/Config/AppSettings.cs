using Microsoft.Extensions.Configuration;
using System;

namespace Stack.Exceptionless.Config
{
    /// <summary>
    /// 应用程序配置
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// 配置文件
        /// </summary>
        private static readonly IConfiguration Configuration = null;

        /// <summary>
        /// 初始化配置文件
        /// </summary>
        static AppSettings()
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(AppContext.BaseDirectory)
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string this[string key]
        {
            get
            {
                return Configuration[key];
            }
        }
    }
}