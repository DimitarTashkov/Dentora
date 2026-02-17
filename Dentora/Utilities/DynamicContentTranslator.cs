using System;

namespace Dentora.Utilities
{
    public static class DynamicContentTranslator
    {
        public static class EntitiesTranslation
        {
            public static string Username => "Username";
            public static string UsernameExists => "Such username exists!";

            public static string Password => "Password";
            public static string ProfilePicture => "Picture is required";
            public static string ProfileRegistered => "Profile registered successfully!";
            public static string ProfileUpdatedSuccessfully => "Profile updated successfully!";
            public static string ProfileUpdateFailed => "Failed to update profile! Please try again!";
            public static string ProfileDeleteWarning => "Are you sure you want to delete your account? This action cannot be undone!";
            public static string ProfileDeletionSuccessful => "Your account has been deleted successfully!";
            public static string ProfileDeletionFailed => "Failed to delete the account! Please try again!";

            public static string EmptyInputData => "Please fill in all input fields!";
            public static string EmptyOrInvalidImage => "An error occured while processing your image!";
            public static string InvalidUserCredentials => "Invalid username or password!";
            public static string SlotNotAvailable => "The selected time slot is not available!";
            public static string TreatmentTitleExists => "A treatment with this title already exists";
            public static string InvalidAppointmentDate => "Appointment date must be in the future!";

            public static string ReadMore => "Read more";
            public static string ItemName => "Name:";
            public static string ItemDescription => "Description:";

            public static string Update => "Edit";

            public static string BookAppointment => "Book Appointment";
            public static string Cancel => "Cancel";

            public static string Edit => "Edit";
            public static string Delete => "Delete";

            public static string TreatmentTitle => "Treatment:";
            public static string Price => "Total price:";
            public static string AppointmentDate => "Appointment date:";
            public static string Confirmation => "Confirmation";
            public static string ConfirmationMessage => "Are you sure you want to cancel your appointment?";

            public static string Category => "Category:";
            public static string Error => "Error";
            public static string Success => "Success";
            public static string DeletionSuccessful => "Deletion successful.";
            public static string DeletionFailed => "Deletion failed.";
            public static string EditFailed => "Edit Failed";
            public static string EditSucceeded => "Updated successfully";

            public static string CreateFailed => "Create Failed";
            public static string CreatedSuccessfully => "Created successfully";

            public static string FieldLength => "{0} should be atleast {1} characters long";
        }
    }
}
