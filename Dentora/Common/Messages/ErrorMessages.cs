namespace Dentora.Common.Messages
{
    public static class ErrorMessages
    {
        public static class TreatmentMessages
        {
            public const string TreatmentTitleIsRequired = "Treatment title is required";
            public const string PriceIsRequired = "Defining price is required";
            public const string CategoryIsRequired = "Treatment category is required";
            public const string TreatmentImageRequired = "Treatment image is required";
            public const string DurationIsRequired = "Duration is required";
            public const string TreatmentTitleExists = "A treatment with this title already exists";
        }

        public static class UserMessages
        {
            public const string UsernameIsRequired = "Username is required";
            public const string PasswordIsRequired = "Password is required";
            public const string EmailIsRequired = "Email is required";
            public const string AvatarIsRequired = "Profile picture is required";
            public const string InvalidUserCredentials = "Invalid username or password!";
            public const string UsernameExists = "Such username already exists!";
        }

        public static class ServicesMessages
        {
            public const string ServiceNameIsRequired = "Service name is required";
            public const string ServiceDescriptionIsRequired = "Service description is required";
        }

        public static class ReviewsMessages
        {
            public const string MessageIsRequired = "Message is required for reviews!";
        }
    }
}
