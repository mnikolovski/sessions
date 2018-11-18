using System;
using System.Runtime.Serialization;

namespace WebApplication.Security.DataRepository.Models
{
    /// <summary>
    /// Represents the status of the user account
    /// </summary>
    [DataContract]
    [Serializable]
    public enum UserStatus
    {
        /// <summary>
        /// Normal - all good
        /// </summary>
        [EnumMember]
        Normal,
        /// <summary>
        /// Fraudlent account - Tried to abuse the system, can't manage invoices
        /// </summary>
        [EnumMember]
        Fraudlent,
        /// <summary>
        /// Locked account - can't login
        /// </summary>
        [EnumMember]
        Locked
    }
}
