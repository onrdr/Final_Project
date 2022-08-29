
using Core.Entities.Concrete;
using System.Runtime.Serialization;

namespace Business.Constants
{
    public static class Messages
    {
        public const string ProductAdded = "Product added successfully";

        public const string ProductNameInvalid = "Invalid Product Name";

        public const string ProductsListed = "Products listed";

        public const string MaintenanceTime = "System Maintenance";

        public const string ProductCountCategoryError = "Every category can contain max of 10 products";

        public const string ProductNameAlreadyExists = "Cannot add product with the same name";

        public const string CategoryLimitExceeded = "Cannot add product due to exceeded category limit";

        public const string AuthorizationDenied = "You are not authorized";

        public const string UserRegistered = "User registered successfully";

        public const string UserNotFound = "User not found";

        public const string PasswordError = "Password error";

        public const string SuccessfulLogin = "Login successfull";

        public const string UserAlreadyExists = "UserAlreadyExists";

        public const string AccessTokenCreated = "AccessTokenCreated";
    }
}
