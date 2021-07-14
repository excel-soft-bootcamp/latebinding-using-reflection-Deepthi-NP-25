using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConditionLib
{
    public class ConditionType
    {
        public static System.Type FindClass(System.Reflection.Assembly _assemblyRef, string name)
        {
            System.Type classType = _assemblyRef.GetType(name);
            if (classType != null)
            {
                if (classType.IsClass)
                {
                    return classType;

                }
            }
            return null;
        }


        public static object InvokeMethod(object source, System.Reflection.MethodInfo methodRef, object[] arguments)
        {
            return methodRef.Invoke(source, arguments);
        }
    }
}


