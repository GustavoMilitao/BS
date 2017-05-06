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
    using System.Collections.Generic;


    [Serializable()]
    public class Npc : IData
    {
        
        public virtual int Id
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
        
        private int mId;
        
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
        
        public virtual List<List<int>> DialogMessages
        {
            get
            {
                return mDialogMessages;
            }
            set
            {
                mDialogMessages = value;
            }
        }
        
        private List<List<int>> mDialogMessages = new List<List<int>>();
        
        public virtual List<List<int>> DialogReplies
        {
            get
            {
                return mDialogReplies;
            }
            set
            {
                mDialogReplies = value;
            }
        }
        
        private List<List<int>> mDialogReplies = new List<List<int>>();
        
        public virtual List<uint> Actions
        {
            get
            {
                return mActions;
            }
            set
            {
                mActions = value;
            }
        }
        
        private List<uint> mActions = new List<uint>();
        
        public virtual uint Gender
        {
            get
            {
                return mGender;
            }
            set
            {
                mGender = value;
            }
        }
        
        private uint mGender;
        
        public virtual string Look
        {
            get
            {
                return mLook;
            }
            set
            {
                mLook = value;
            }
        }
        
        private string mLook;
        
        public virtual int TokenShop
        {
            get
            {
                return mTokenShop;
            }
            set
            {
                mTokenShop = value;
            }
        }
        
        private int mTokenShop;
        
        public virtual List<AnimFunNpcData> AnimFunList
        {
            get
            {
                return mAnimFunList;
            }
            set
            {
                mAnimFunList = value;
            }
        }
        
        private List<AnimFunNpcData> mAnimFunList = new List<AnimFunNpcData>();
        
        public virtual bool FastAnimsFun
        {
            get
            {
                return mFastAnimsFun;
            }
            set
            {
                mFastAnimsFun = value;
            }
        }
        
        private bool mFastAnimsFun;
        
        public Npc()
        {
        }
    }
}
