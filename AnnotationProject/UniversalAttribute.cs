using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Reflection;
using System.Text.RegularExpressions;
using AnnotationProject;

namespace AnnotationProject
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
    public class UniversalAttribute : Attribute
    {
        public string Message { get; }
        public int MinLength { get; }

        public UniversalAttribute(string message)
        {
            Message = message;
        }

        public UniversalAttribute(string message, int minLength = 0)
        {
            Message = message;
            MinLength = minLength;
        }

        // Ensures string has required minimum length
        public bool IsValid(string value)
        {
            return value != null && value.Length >= MinLength;
        }

        // Ensures username has special character
        public bool UsernameValid(string value)
        {
           return !string.IsNullOrEmpty(value) && Regex.IsMatch(value, @"\d");
        }

        // Ensures class is a subclass of BaseUser
        public static bool IsSubclassOfBaseUser(Type type)
        {
            return type.IsSubclassOf(typeof(BaseUser));
        }

        // Ensures method is non-static
        public static bool IsMethodNonStatic(MethodInfo method)
        {
            return !method.IsStatic;
        }
    }

}
