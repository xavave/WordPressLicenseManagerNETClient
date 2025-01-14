![NuGet](https://img.shields.io/nuget/v/WPLMNETClient_Extended.svg) 



# WordPressLicenseManagerNETClient_Extended
A .NET standard client for  Software License Manager (https://wordpress.org/plugins/software-license-manager/). A better fork of the software license manager wordpress plugin with woocommerce integration can be found [here](https://github.com/Arsenal21/software-license-manager) (https://github.com/Arsenal21/software-license-manager) Disclaimer: Have not tested it.

# NuGet

Find it [here](https://www.nuget.org/packages/WPLMNETClient_Extended/).

``` Install-Package WPLMNETClient_Extended ```

thanks to  https://github.com/jliliamen/WordPressLicenseManagerNETClient for first version 
 
# Examples

## Actions 
Four actions are available. You can create a new license, activate/deactivate a pending license or check the meta data of a license.

## Configuration class

The configuration class is where you stored the credentials required. The ``` secret key ``` is only required to create a new license. The ``` activation key ``` is required to complete the other actions.

## Sample

This sample shows how to activate a pending license. Deactivation and creation of license is very similar to this example.

 ```csharp 
 
        Configuration configuration = default(Configuration);
        ILicenseManager licenseManager = default(ILicenseManager);
        License license = default(License);
        public void Main()
        {
            // create configuration object
            configuration = new Configuration();
            configuration.PostURL = "http://chucknorris.co";
            configuration.ActivationKey = "abc";
            configuration.SecretKey = "123";
            // create license manager
            licenseManager = LicenseManagerFactory.New(configuration);
            // create license object 
            license = new License();
            license.Email = "charles@chucknorris.co";
            license.Key = "password123";
            license.FirstName = "Chuck";
            license.LastName = "Norris";
            license.CompanyName = "Chuck Norris Unlimited Liability Co";
            license.MaximumDomainAllowed = 1;
        
            ActivateLicenseKey();
        }


        
        public void ActivateLicenseKey()
        {
            var licenseResponse = licenseManager.PerformAction(WordPressLicenseManagerNETClient.Consts.Action.Activate, license);
            if (licenseResponse.Success == false)
                throw new Exception(licenseResponse.Message);
            else
                Assert.IsTrue(licenseResponse.Success);
        }
 ```

