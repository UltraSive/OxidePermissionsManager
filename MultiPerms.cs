namespace Oxide.Plugins

{
    [Info("Multiple Permissions", "UltraSive", "0.0.1")]
	[Description("Use O.show command to copy perms or revoke them.")]
    class MultiPerms : CovalencePlugin
    {
        string[] findPermissions(string permissions)
		{
			string[] permissionsArray = permissions.Split(", ");
			return permissionsArray;
		}
		
		[Command("groupgrantperms")]
        void grantGroup(string group, string perms)
        {
            permsArray = findPermissions(perms);
			
			if (permsArray != null) 
			{
				for (int i = permsArray.Length - 1; i >= 0; i--) 
				{
					permission.GrantGroupPermission(group, permsArray[i], null);
				}
			}
        }
		
		[Command("usergrantperms")]
        void grantUser(string user, string perms)
        {
			permsArray = findPermissions(perms);
			
            if (permsArray != null) 
			{
				for (int i = permsArray.Length - 1; i >= 0; i--) 
				{
					permission.GrantUserPermission(user, permsArray[i], null);
				}
			}
        }
		
		[Command("grouprevokeperms")]
        void revokeGroup(string group, string perms)
        {
			permsArray = findPermissions(perms);
			
            if (permsArray != null) 
			{
				for (int i = permsArray.Length - 1; i >= 0; i--) 
				{
					permission.RevokeGroupPermission(group, permsArray[i]);
				}
			}
        }
		
		[Command("userrevokeperms")]
        void RevokeUser(string user, string perms)
        {
			permsArray = findPermissions(perms);

            if (permsArray != null) 
			{
				for (int i = permsArray.Length - 1; i >= 0; i--) 
				{
					permission.RevokeUserPermission(user, permsArray[i]);
				}
			}
        }
    }
}