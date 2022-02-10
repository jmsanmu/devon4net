using Devon4Net.Infrastructure.AWS.Common.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Devon4Net.Infrastructure.Common.Handlers;
using Devon4Net.Infrastructure.AWS.Common.Consts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devon4Net.Infrastructure.AWS.SQS
{
    public static class SqsConfiguration
    {
        public static void SetupSqs(this IServiceCollection services, IConfiguration configuration)
        {
            var awsOptions = services.GetTypedOptions<AwsOptions>(configuration, ConfigurationConsts.AwsOptionsNodeName);

            awsOptions.SqsOptions
        }
    }
}
