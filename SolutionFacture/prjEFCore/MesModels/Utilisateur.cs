using System;
using System.Collections.Generic;

#nullable disable

namespace prjEFCore.Models
{
    public partial class Utilisateur
    {
        public static string ADMIN = "administrator";
        public static string USER = "user";
    }

    public enum ERole
    {
        administrator,
        user
    }
}
