//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.DataCenter
{
    using System;


    [Serializable()]
    public class AbuseReasons : IData
    {
        
        public virtual uint AbuseReasonId
        {
            get
            {
                return mAbuseReasonId;
            }
            set
            {
                mAbuseReasonId = value;
            }
        }
        
        private uint mAbuseReasonId;
        
        public virtual uint Mask
        {
            get
            {
                return mMask;
            }
            set
            {
                mMask = value;
            }
        }
        
        private uint mMask;
        
        public virtual int ReasonTextId
        {
            get
            {
                return mReasonTextId;
            }
            set
            {
                mReasonTextId = value;
            }
        }
        
        private int mReasonTextId;
        
        public AbuseReasons()
        {
        }
    }
}
