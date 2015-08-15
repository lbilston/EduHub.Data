﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Schools
    /// </summary>
    public class SKGS_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// School ID [Uppercase Alphanumeric: u8]
        /// </summary>
        public string SCHOOL { get; internal set; }
        /// <summary>
        /// School Name [Alphanumeric: a40]
        /// </summary>
        public string NAME { get; internal set; }
        /// <summary>
        /// School type: Primary, Secondary, Special, etc [Alphanumeric: a33]
        /// </summary>
        public string SCHOOL_TYPE { get; internal set; }
        /// <summary>
        /// School type: Government, Private, etc [Uppercase Alphanumeric: u2]
        /// </summary>
        public string ENTITY { get; internal set; }
        /// <summary>
        /// DEET-defined school ID [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SCHOOL_ID { get; internal set; }
        /// <summary>
        /// (Was SCHOOL_CAMPUS) Campus number [Uppercase Alphanumeric: u2]
        /// </summary>
        public string SCHOOL_NUMBER { get; internal set; }
        /// <summary>
        /// Campus type: Primary, etc [Alphanumeric: a33]
        /// </summary>
        public string CAMPUS_TYPE { get; internal set; }
        /// <summary>
        /// Campus name [Alphanumeric: a40]
        /// </summary>
        public string CAMPUS_NAME { get; internal set; }
        /// <summary>
        /// Region [Integer (16bit signed nullable): i]
        /// </summary>
        public short? REGION { get; internal set; }
        /// <summary>
        /// Name of Region [Alphanumeric: a30]
        /// </summary>
        public string REGION_NAME { get; internal set; }
        /// <summary>
        /// Two address lines [Alphanumeric: a30]
        /// </summary>
        public string ADDRESS01 { get; internal set; }
        /// <summary>
        /// Two address lines [Alphanumeric: a30]
        /// </summary>
        public string ADDRESS02 { get; internal set; }
        /// <summary>
        /// Suburb name [Alphanumeric: a30]
        /// </summary>
        public string SUBURB { get; internal set; }
        /// <summary>
        /// State code [Uppercase Alphanumeric: u3]
        /// </summary>
        public string STATE { get; internal set; }
        /// <summary>
        /// Postcode [Alphanumeric: a4]
        /// </summary>
        public string POSTCODE { get; internal set; }
        /// <summary>
        /// Phone no [Uppercase Alphanumeric: u20]
        /// </summary>
        public string TELEPHONE { get; internal set; }
        /// <summary>
        /// Fax no [Uppercase Alphanumeric: u20]
        /// </summary>
        public string FAX { get; internal set; }
        /// <summary>
        /// Two address lines [Alphanumeric: a30]
        /// </summary>
        public string MAILING_ADDRESS01 { get; internal set; }
        /// <summary>
        /// Two address lines [Alphanumeric: a30]
        /// </summary>
        public string MAILING_ADDRESS02 { get; internal set; }
        /// <summary>
        /// Suburb name for Mailing [Alphanumeric: a30]
        /// </summary>
        public string MAILING_SUBURB { get; internal set; }
        /// <summary>
        /// State code for Mailing [Uppercase Alphanumeric: u3]
        /// </summary>
        public string MAILING_STATE { get; internal set; }
        /// <summary>
        /// Postcode for Mailing [Alphanumeric: a4]
        /// </summary>
        public string MAILING_POSTCODE { get; internal set; }
        /// <summary>
        /// Two address lines for Delivery [Alphanumeric: a30]
        /// </summary>
        public string DELIVERY_ADDRESS01 { get; internal set; }
        /// <summary>
        /// Two address lines for Delivery [Alphanumeric: a30]
        /// </summary>
        public string DELIVERY_ADDRESS02 { get; internal set; }
        /// <summary>
        /// Suburb name for Delivery [Alphanumeric: a30]
        /// </summary>
        public string DELIVERY_SUBURB { get; internal set; }
        /// <summary>
        /// State code for Delivery [Uppercase Alphanumeric: u3]
        /// </summary>
        public string DELIVERY_STATE { get; internal set; }
        /// <summary>
        /// Postcode for Delivery [Alphanumeric: a4]
        /// </summary>
        public string DELIVERY_POSTCODE { get; internal set; }
        /// <summary>
        /// Phone no. for Delivery [Uppercase Alphanumeric: u20]
        /// </summary>
        public string DELIVERY_TELEPHONE { get; internal set; }
        /// <summary>
        /// Fax no for Delivery [Uppercase Alphanumeric: u20]
        /// </summary>
        public string DELIVERY_FAX { get; internal set; }
        /// <summary>
        /// (Was E_MAIL_ADDRESS) E-mail address [Alphanumeric: a255]
        /// </summary>
        public string E_MAIL { get; internal set; }
        /// <summary>
        /// Internet address [Alphanumeric: a255]
        /// </summary>
        public string INTERNET_ADDRESS { get; internal set; }
        /// <summary>
        /// CASES 21 release no [Uppercase Alphanumeric: u12]
        /// </summary>
        public string CASES21_RELEASE { get; internal set; }
        /// <summary>
        /// Melway, VicRoads, Country Fire Authority, etc [Uppercase Alphanumeric: u1]
        /// </summary>
        public string MAP_TYPE { get; internal set; }
        /// <summary>
        /// Map no [Uppercase Alphanumeric: u4]
        /// </summary>
        public string MAP_NUM { get; internal set; }
        /// <summary>
        /// Horizontal grid reference [Uppercase Alphanumeric: u2]
        /// </summary>
        public string X_AXIS { get; internal set; }
        /// <summary>
        /// Vertical grid reference [Uppercase Alphanumeric: u2]
        /// </summary>
        public string Y_AXIS { get; internal set; }
        /// <summary>
        /// School Principal's Title: Mr, Mrs, etc [Titlecase: t4]
        /// </summary>
        public string SCH_PRINCIPAL_SALUTATION { get; internal set; }
        /// <summary>
        /// School Principal's First Name [Titlecase: t20]
        /// </summary>
        public string SCH_PRINCIPAL_FIRST_NAME { get; internal set; }
        /// <summary>
        /// School Principal's Surname [Uppercase Alphanumeric: u30]
        /// </summary>
        public string SCH_PRINCIPAL_SURNAME { get; internal set; }
        /// <summary>
        /// School Principal's Phone no [Uppercase Alphanumeric: u20]
        /// </summary>
        public string SCH_PRINCIPAL_TELEPHONE { get; internal set; }
        /// <summary>
        /// Campus Principal's title: Mr, Mrs, etc [Titlecase: t4]
        /// </summary>
        public string SALUTATION { get; internal set; }
        /// <summary>
        /// Campus Principal's surname [Uppercase Alphanumeric: u30]
        /// </summary>
        public string SURNAME { get; internal set; }
        /// <summary>
        /// Campus Principal's first given name [Titlecase: t20]
        /// </summary>
        public string FIRST_NAME { get; internal set; }
        /// <summary>
        /// School closed? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CLOSED { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
