using Core.Entities.ValueObjects;
using Core.Enums;

namespace Core.Entities
{
    public class AccountSettings
    {
        public int AccountId { get; init; }
        
        public SettingState ReadBook { get; set; } = null!;
        
        public SettingState AddToLibrary { get; set; } = null!;

        public SettingState LikeTheBook { get; set; } = null!;
        
        public SettingState SubscribeToTheAuthor { get; set; } = null!;

        public SettingState PostComment { get; set; } = null!;

        public SettingState MakeADonationToTheAuthor { get; set; } = null!;

        public SettingState BuyABook { get; set; } = null!;
        
        public int ConstantDelay { get; set; } = 1000;
        
        public int FloatingIncrementalDelay { get; set; } = 500;
        
        public ReadProfile ReadProfile { get; set; } = ReadProfile.DeepReader;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public void UpdateSettings(
            SettingState? readBook,
            SettingState? addToLibrary,
            SettingState? likeTheBook,
            SettingState? subscribeToTheAuthor,
            SettingState? postComment,
            SettingState? makeADonationToTheAuthor,
            SettingState? buyABook,
            ReadProfile readProfile)
        {
            if (readBook is not null)
                ReadBook = readBook;
            
            if (addToLibrary is not null)
                AddToLibrary = addToLibrary;
            
            if (likeTheBook is not null)
                LikeTheBook = likeTheBook;
            
            if (subscribeToTheAuthor is not null)
                SubscribeToTheAuthor = subscribeToTheAuthor;
            
            if (postComment is not null)
                PostComment = postComment;
            
            if (makeADonationToTheAuthor is not null)
                MakeADonationToTheAuthor = makeADonationToTheAuthor;
            
            if (buyABook is not null)
                BuyABook = buyABook;

            ReadProfile = readProfile;
            
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
