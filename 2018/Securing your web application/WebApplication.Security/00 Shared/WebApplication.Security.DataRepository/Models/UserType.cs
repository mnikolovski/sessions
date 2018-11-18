using System;
using System.Runtime.Serialization;

namespace WebApplication.Security.DataRepository.Models
{
    /// <summary>
    /// Represents the user type 
    /// </summary>
    [DataContract]
    [Serializable]
    public enum UserType
    {
        /// <summary>
        /// Anonymous app user
        /// </summary>
        [EnumMember]
        Anonymous,
        /// <summary>
        /// Individual customer user of the app
        /// </summary>
        [EnumMember]
        Customer,
        /// <summary>
        /// Administrator of the system
        /// </summary>
        [EnumMember]
        SystemAdministrator
    }
}
