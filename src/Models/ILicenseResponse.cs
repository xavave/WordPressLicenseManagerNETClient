﻿using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WordPressLicenseManagerNETClient.Models
{
    /// <summary>
    /// License response
    /// </summary>
    public interface ILicenseResponse
    {
        /// <summary>
        /// Id
        /// </summary>
        int Id { get; }
        /// <summary>
        /// Success or failure
        /// </summary>
        bool Success { get; }
        /// <summary>
        /// Response message
        /// </summary>
        string Message { get; }

        /// <summary>
        /// License key
        /// </summary>
        string Key { get; }

        /// <summary>
        /// License status
        /// </summary>
        string Status { get; }

        /// <summary>
        /// License mode (trial/registered)
        /// </summary>
        string Mode { get; }

        /// <summary>
        /// IP Address
        /// </summary>
        string IPAddress { get; }

        /// <summary>
        /// Software version
        /// </summary>
        string Version { get; }

        /// <summary>
        /// Maximum of allowed domains
        /// </summary>
        int MaximumAllowedDomains { get; }

        /// <summary>
        /// Email
        /// </summary>
        string Email { get; }
        /// <summary>
        /// List of registered domains
        /// </summary>
        List<RegisteredDomain> RegisteredDomains { get; }

        /// <summary>
        /// Creation date
        /// </summary>
        string DateCreated { get; }

        /// <summary>
        /// Renewal date
        /// </summary>
        string DateRenewed { get; }

        /// <summary>
        /// Expiry date
        /// </summary>
        string DateExpiry { get; }

        /// <summary>
        /// Product reference
        /// </summary>
        string ProductReference { get; }
        /// <summary>
        ///  First name
        /// </summary>
        string FirstName { get; }
        /// <summary>
        /// Last name
        /// </summary>
        string LastName { get; }
        /// <summary>
        /// Company name
        /// </summary>
        string CompanyName { get; }

        /// <summary>
        /// Tax ID
        /// </summary>
        string TaxID { get; }

        /// <summary>
        /// Susbcriber ID
        /// </summary>
        string SubscriberID { get; }
        /// <summary>
        /// Error code
        /// </summary>
        int ErrorCode { get; }






    }


    class LicenseResponse : ILicenseResponse, INotifyPropertyChanged
    {

        [JsonProperty("license_key")]
        private string licenseKey = string.Empty;
        public string LicenseKey
        {
            get { return licenseKey; }
            set
            {

                licenseKey = value;
                PropertyChanged(this, new PropertyChangedEventArgs("LicenseKey"));
            }
        }
        [JsonProperty("id")]
        public int Id { get; private set; }
        [JsonProperty("key")]
        public string Key { get; private set; }

        [JsonProperty("status")]
        public string Status { get; private set; }

        [JsonProperty("max_allowed_domains")]
        public int MaximumAllowedDomains { get; private set; } = 1;

        [JsonProperty("email")]
        public string Email { get; private set; }
        [JsonProperty("registered_domains")]
        public List<RegisteredDomain> RegisteredDomains { get; private set; }

        [JsonProperty("date_created")]
        public string DateCreated { get; private set; }

        [JsonProperty("date_renewed")]
        public string DateRenewed { get; private set; }

        [JsonProperty("date_expiry")]
        public string DateExpiry { get; private set; }

        [JsonProperty("lic_mode")]
        public string Mode { get; private set; }

        [JsonProperty("ip_address")]
        public string IPAddress { get; private set; }

        [JsonProperty("version")]
        public string Version { get; private set; }


        [JsonProperty("product_ref")]
        public string ProductReference { get; private set; }
        [JsonProperty("first_name")]
        public string FirstName { get; private set; }
        [JsonProperty("last_name")]
        public string LastName { get; private set; }

        [JsonProperty("company_name ")]
        public string CompanyName { get; private set; }

        [JsonProperty("txn_id")]
        public string TaxID { get; private set; }
        [JsonProperty("subscr_id")]
        public string SubscriberID { get; private set; }


        public bool Success { get; private set; } = true;
        private string r;
        public string result
        {
            get { return r; }
            set
            {
                r = value;
                PropertyChanged(this, new PropertyChangedEventArgs("result"));
            }
        }
        [JsonProperty("message")]
        public string Message { get; private set; }
        [JsonProperty("error_code")]
        public int ErrorCode { get; private set; }



        public event PropertyChangedEventHandler PropertyChanged;


        public LicenseResponse()
        {
            this.PropertyChanged += LicenseResponse_PropertyChanged;
        }

        private void LicenseResponse_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "result")
            {
                if (this.result == "error")
                    Success = false;
                else
                    Success = true;
            }

        }

        public void Raise()
        {
            if (string.IsNullOrWhiteSpace(LicenseKey) == false)
                Key = LicenseKey;
        }
    }
}
