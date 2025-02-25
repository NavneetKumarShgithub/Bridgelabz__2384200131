using System.Reflection;

namespace AnnotationProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass("ABC","1");

            Type userType = typeof(MyClass);

            // ✅ Class-Level Validation (Must inherit from BaseUser)

            if (!UniversalAttribute.IsSubclassOfBaseUser(userType))
            {
                Console.WriteLine($"Class Validation Failed: {userType.Name} is not a subclass of BaseUser.");
                return;
            }
            else
            {
                Console.WriteLine($"Class Validation Passed: {userType.Name} is a valid subclass.");
            }

            // ✅ Field-Level Validation (Check Min Length)

            FieldInfo field = userType.GetField("Name");

            if (field.GetCustomAttribute(typeof(UniversalAttribute)) is UniversalAttribute fieldAttr)
            {
                string fieldValue = (string)field.GetValue(myClass);

                if (!fieldAttr.IsValid(fieldValue))
                {
                    Console.WriteLine($"Field Validation Failed: {fieldAttr.Message}");
                    return;
                }
            }

            // ✅ Property-Level Validation (Check Min Length)

            PropertyInfo property = userType.GetProperty("Username");

            if (property.GetCustomAttribute(typeof(UniversalAttribute)) is UniversalAttribute propertyAttr)
            {
                string propertyValue = (string)property.GetValue(myClass);

                if (!propertyAttr.UsernameValid(propertyValue))
                {
                    Console.WriteLine($"Property Validation Failed: {propertyAttr.Message}");
                    return;
                }
            }

            // ✅ Method-Level Validation (Ensure Non-Static)

            MethodInfo method = userType.GetMethod("PrintDetails");
            
            if (method.GetCustomAttribute(typeof(UniversalAttribute)) is UniversalAttribute methodAttr)
            {
                if (!UniversalAttribute.IsMethodNonStatic(method))
                {
                    Console.WriteLine("Method Validation Failed: The method is static and cannot be executed.");
                    return;
                }

                Console.WriteLine($"Method Validation: {methodAttr.Message}");
                method.Invoke(myClass, null);  // Execute method if valid
            }

        }
    }
}
