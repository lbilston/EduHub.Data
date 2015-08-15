﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Publications
    /// </summary>
    public class SPU_Entity : EntityBase
    {
#region Navigation Property Cache
        private SG_Entity _MAILING_LIST_SG;
        private KGL_Entity _HOME_LANGUAGE_KGL;
#endregion

#region Field Properties
        /// <summary>
        /// Publication code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SPUKEY { get; internal set; }
        /// <summary>
        /// Publication title [Alphanumeric: a30]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Description of publication [Memo: m]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Target audience [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TARGET { get; internal set; }
        /// <summary>
        /// Whether publication is in English only or community languages [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LANGUAGE_INDICATOR { get; internal set; }
        /// <summary>
        /// Mailing mechanism: mail, electronic, by hand [Uppercase Alphanumeric: u1]
        /// </summary>
        public string MAILING_MECHANISM { get; internal set; }
        /// <summary>
        /// Publication type: Labels, envelopes, documents [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PUBLICATION_TYPE { get; internal set; }
        /// <summary>
        /// Comment to go above address (if required) [Alphanumeric: a40]
        /// </summary>
        public string ADDRESS_COMMENT { get; internal set; }
        /// <summary>
        /// Is this document to go to each student, or one per family [Uppercase Alphanumeric: u1]
        /// </summary>
        public string STUDENT_SPECIFIC { get; internal set; }
        /// <summary>
        /// Code of group of students to which this publication is to go [Uppercase Alphanumeric: u12]
        /// </summary>
        public string MAILING_LIST { get; internal set; }
        /// <summary>
        /// Indicates whether publication is to go to all students eligible for the group or only actual members [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACTUAL_ELIGIBLE_MEMBERS { get; internal set; }
        /// <summary>
        /// If filled publication only goes to students with matching ST.HOME_LANG [Uppercase Alphanumeric: u7]
        /// </summary>
        public string HOME_LANGUAGE { get; internal set; }
        /// <summary>
        /// Required sorting sequence: C=Community language, P=Postcode, H=Home group [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PRIMARY_SORT { get; internal set; }
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
        /// <summary>
        /// Navigation property for [MAILING_LIST] => [SG_Entity].[SGKEY]
        /// Code of group of students to which this publication is to go
        /// </summary>
        public SG_Entity MAILING_LIST_SG {
            get
            {
                if (MAILING_LIST != null)
                {
                    if (_MAILING_LIST_SG == null)
                    {
                        _MAILING_LIST_SG = Context.SG.FindBySGKEY(MAILING_LIST);
                    }
                    return _MAILING_LIST_SG;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [HOME_LANGUAGE] => [KGL_Entity].[KGLKEY]
        /// If filled publication only goes to students with matching ST.HOME_LANG
        /// </summary>
        public KGL_Entity HOME_LANGUAGE_KGL {
            get
            {
                if (HOME_LANGUAGE != null)
                {
                    if (_HOME_LANGUAGE_KGL == null)
                    {
                        _HOME_LANGUAGE_KGL = Context.KGL.FindByKGLKEY(HOME_LANGUAGE);
                    }
                    return _HOME_LANGUAGE_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
#endregion
    }
}
