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
    using System.Collections.Generic;
    using System;


    [Serializable()]
    public class AchievementCategory : IData
    {
        
        public virtual uint Id
        {
            get
            {
                return mId;
            }
            set
            {
                mId = value;
            }
        }
        
        private uint mId;
        
        public virtual uint NameId
        {
            get
            {
                return mNameId;
            }
            set
            {
                mNameId = value;
            }
        }
        
        private uint mNameId;
        
        public virtual uint ParentId
        {
            get
            {
                return mParentId;
            }
            set
            {
                mParentId = value;
            }
        }
        
        private uint mParentId;
        
        public virtual string Icon
        {
            get
            {
                return mIcon;
            }
            set
            {
                mIcon = value;
            }
        }
        
        private string mIcon;
        
        public virtual uint Order
        {
            get
            {
                return mOrder;
            }
            set
            {
                mOrder = value;
            }
        }
        
        private uint mOrder;
        
        public virtual string Color
        {
            get
            {
                return mColor;
            }
            set
            {
                mColor = value;
            }
        }
        
        private string mColor;
        
        public virtual List<uint> AchievementIds
        {
            get
            {
                return mAchievementIds;
            }
            set
            {
                mAchievementIds = value;
            }
        }
        
        private List<uint> mAchievementIds = new List<uint>();
        
        public AchievementCategory()
        {
        }
    }
}