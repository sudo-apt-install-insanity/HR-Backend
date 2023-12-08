namespace HrDatabaseBackend.Model.UserModel
{
    public class UserDatabaseSetting : IUserDatabaseSetting
    {
        public string UserCollectionName { get ; set ; }
        public string ConnectionString { get ; set; }
        public string DatabaseName { get; set; }
    }
}
