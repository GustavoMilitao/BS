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
    public class Pet : IData
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
        
        public virtual List<int> FoodItems
        {
            get
            {
                return mFoodItems;
            }
            set
            {
                mFoodItems = value;
            }
        }
        
        private List<int> mFoodItems = new List<int>();
        
        public virtual List<int> FoodTypes
        {
            get
            {
                return mFoodTypes;
            }
            set
            {
                mFoodTypes = value;
            }
        }
        
        private List<int> mFoodTypes = new List<int>();
        
        public virtual int MinDurationBeforeMeal
        {
            get
            {
                return mMinDurationBeforeMeal;
            }
            set
            {
                mMinDurationBeforeMeal = value;
            }
        }
        
        private int mMinDurationBeforeMeal;
        
        public virtual int MaxDurationBeforeMeal
        {
            get
            {
                return mMaxDurationBeforeMeal;
            }
            set
            {
                mMaxDurationBeforeMeal = value;
            }
        }
        
        private int mMaxDurationBeforeMeal;
        
        public virtual List<EffectInstance> PossibleEffects
        {
            get
            {
                return mPossibleEffects;
            }
            set
            {
                mPossibleEffects = value;
            }
        }
        
        private List<EffectInstance> mPossibleEffects = new List<EffectInstance>();
        
        public Pet()
        {
        }
    }
}
