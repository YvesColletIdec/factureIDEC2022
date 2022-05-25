using System;
using System.Collections.Generic;

#nullable disable

namespace prjEFCore.Models
{
    public partial class Utilisateur
    {
        public static string ADMIN_ROLE = "administrator";
        public static string USER_ROLE = "user";
        public static string ADMIN_NOM = "admin";
    }

    public enum ERole
    {
        administrator,
        user
    }
}
