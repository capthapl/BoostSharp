using System;
namespace BoostSharp.Universal
{
    public class Review
    {
        public string Description { get; set; }
        public string EmailOwner { get; set; }
        public string DisplayNameOwner { get; set; }
        public EReviewType ReviewType { get; set; }
        public string DisplayReview
        {
            get
            {
                switch (ReviewType)
                {
                    case EReviewType.negative:
                        return "negatywna";
                    case EReviewType.positive:
                        return "pozytywna";
                    default:
                        return "neutralna";
                }
            }
        }
        public Review()
        {

        }

        public Review(string description, string emailOwner, string displayNameOwner, EReviewType reviewType)
        {
            Description = description;
            EmailOwner = emailOwner;
            DisplayNameOwner = displayNameOwner;
            ReviewType = reviewType;
        }
    }
}
