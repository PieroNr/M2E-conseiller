using Smoby.Models.CloudConfiguration;
using ConfigurationData = Smoby.Models.CloudConfiguration.Database.Configuration;

namespace M2E_conseiller
{
    public class CloudConfigurationParameters: ConfigurationResult,ICloudConfigurationOptions
    {
        public string CloudConfigurationUrl { get; } ="https://cloudconfiguration-api-qvr.pe-qvr.fr/api/Configuration/GetConfigurations";
        public string CloudConfigurationApplicationId { get; } ="a4e422e1-bdc8-437f-806c-9a16939ac495";
        public string CloudConfigurationApiKey { get; } ="IH3ceNV2Yz2E1OWrwHsPL6BXROL7wVkgert6pfhb";
        public int CloudConfigurationVersion { get; } = 0;
        public CloudConfigurationParameters()
        {
            AddConfigurations();
            AddFeatures();
            AddWordings();
        }
        public void AddConfigurations()
        {
        }
        void AddFeatures()
        {
        }
        private void AddWordings()
        {
        }
    }
}